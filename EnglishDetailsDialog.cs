﻿using LegalBot.Services;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Choices;
using System;
using System.IO;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LegalBot.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace LegalBot.Dialogs
{   
 
    // It inherits from parent class 
  
    
    public class EnglishDetailsDialog :ComponentDialog
    {
        private readonly BotStateService _botStateService;
        private string jsonFile = @"Json/county.json";
        public EnglishDetailsDialog(string dialogId, BotStateService botStateService) : base(dialogId)
        {
            _botStateService = botStateService ?? throw new ArgumentNullException(nameof(botStateService));
            InitializeWaterfallDialog();
        }
        // Intialize the waterflow dialog...
        private void InitializeWaterfallDialog()
        {
            // create waterfall steps
            var waterfallSteps = new WaterfallStep[]
            {   SelectedLanguageAsync,
                RegisterNameAsync,
                CountyStepAsync,
                SelectedMenuAsync,
                ChooseMenuAsync,
                ChooseActionAsync,
                SubCountyStepAsync,
                WardStepAsync,
                ConfirmationStepAsync
             
                
            };

            AddDialog(new WaterfallDialog($"{nameof(EnglishDetailsDialog)}.mainFlow", waterfallSteps));
            AddDialog(new ChoicePrompt($"{nameof(EnglishDetailsDialog)}.preferredLanguage"));
            AddDialog(new TextPrompt($"{nameof(EnglishDetailsDialog)}.name"));
            AddDialog(new NumberPrompt<int>($"{nameof(EnglishDetailsDialog)}.county"));
            AddDialog(new ChoicePrompt($"{nameof(EnglishDetailsDialog)}.menu"));
            AddDialog(new ChoicePrompt($"{nameof(EnglishDetailsDialog)}.chooseMenu"));
            AddDialog(new ChoicePrompt($"{nameof(EnglishDetailsDialog)}.chooseAction"));
            AddDialog(new NumberPrompt<int>($"{nameof(EnglishDetailsDialog)}.subcounty"));
            AddDialog(new ChoicePrompt($"{nameof(EnglishDetailsDialog)}.ward"));
       
           // // AddDialog(new TextPrompt($"{nameof(EnglishDetailsDialog)}.location"));
            // set the starting dialog 
            InitialDialogId = $"{nameof(EnglishDetailsDialog)}.mainFlow";
        }
        private async Task<DialogTurnResult> SelectedLanguageAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {  
            // Ask the user to enter there preferred language
            var promptOptions = new PromptOptions {
                Prompt = MessageFactory.Text("Hujambo, karibu katika huduma yetu. Tafadhali chagua lugha inayokufaa (1. KISWAHILI),  (2. KINGEREZA)" +
                "Hello, welcome to our service. Please choose your preferred language (1. KISWAHILI),  (2. ENGLISH)"),
                Choices = ChoiceFactory.ToChoices(new List<string> { "English","Kiswahili" }),

            };
            //  Asks the user to enter their name 
            return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.preferredLanguage",promptOptions,cancellationToken);
        }
        private async Task<DialogTurnResult> RegisterNameAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {   
            // Set's the users preferred language to what they entered 
            stepContext.Values["preferredLanguage"] = ((FoundChoice)stepContext.Result).Value;

            if((string) stepContext.Values["preferredLanguage"] == "English"){

                var promptOptions = new PromptOptions {
                    Prompt = MessageFactory.Text("Welcome to our service, we would like to ask you" +
                    "a few questions for the purpose of registration. What is your full name?:"),

                };

                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.name",promptOptions, cancellationToken);

            }

            else {
                var promptOptions = new PromptOptions {
                Prompt = MessageFactory.Text("Karibu katika service yetu ,Tungependa kukuliza maswali ndio tuweze" +
                "kukusajili ,Jina lako ni ?")};
                
                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.name",promptOptions, cancellationToken);
                
            }
        }


        private async Task<DialogTurnResult> CountyStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {   
            // setting the users name 
            stepContext.Values["name"] = (string)stepContext.Result;
            //  reading data from the json file
            var json = File.ReadAllText(jsonFile);
            
;

            try{
                

              var counties = JsonConvert.DeserializeObject<List<County>>(json);

                string options ="";

                for(int i =0; i<counties.Count; i++){

                            options += $"\n{i+1}.{counties[i].CountyName}\n";
                } 

                if((string) stepContext.Values["preferredLanguage"] == "English"){
                        
                        
                        
                        var promptOptions =  new PromptOptions{
                                Prompt = MessageFactory.Text("Which county do you live in(select a county number) ?\n" + options),
                                RetryPrompt = MessageFactory.Text("Please choose an option from the list."),

                        };
                        return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.county", promptOptions, cancellationToken);
                }
            
                else 
                {
                    var promptOptions = new PromptOptions {
                    Prompt = MessageFactory.Text("Unaishi katika Kaunti gani ?\n" + options),
                    RetryPrompt = MessageFactory.Text("Tafadhali chagua kutoka kwenye list"),

                    };
                    return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.county",promptOptions, cancellationToken);
                }
            }

            catch (Exception)  
            {  
  
                 throw;  
            }
            
        }

        private async Task<DialogTurnResult> SelectedMenuAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            stepContext.Values["county"] = (int)stepContext.Result;

            var promptOptions = new PromptOptions
            {
                Prompt = MessageFactory.Text
                (
                 "Hello, Please choose to continue with our service or go back (1. OTHER OPTIONS),  (2. GO BACK)"),
                Choices = ChoiceFactory.ToChoices(new List<string> { "OTHER OPTIONS", "Go BACK" }),
            };


            return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.menu", promptOptions, cancellationToken);
        }
        private async Task<DialogTurnResult> ChooseMenuAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {   stepContext.Values["menu"] = ((FoundChoice)stepContext.Result).Value;

            if((string) stepContext.Values["menu"] == "OTHER OPTIONS"){

                //string options = "1,2,3,4,5,6";
                var promptOptions = new PromptOptions 
                    {
                    Prompt = MessageFactory.Text("hello ,Welcome back, Please choose from the list\n" ),
                    Choices = ChoiceFactory.ToChoices(new List<string> { "1.INFORMATION", "2. NEWS", " 3. REFFERAL", "4.SURVEY", "5.UPDATE", "6. SHARE" }),


              
                     };

             


                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.chooseMenu",promptOptions, cancellationToken);

            }

            else {
                var promptOptions = new PromptOptions {
                Prompt = MessageFactory.Text(" Go back to the main menu")};
                
                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.chooseMenu",promptOptions, cancellationToken);
                
            }
        }


        private async Task<DialogTurnResult> ChooseActionAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            stepContext.Values["chooseMenu"] = ((FoundChoice)stepContext.Result).Value;
       
                if ((string)stepContext.Values["chooseMenu"] == "6. SHARE")
                {

              
                    var promptOptions = new PromptOptions
                    {
                        Prompt = MessageFactory.Text("Please forward this message to share the service,To access the chatBot click on the link below  tg://resolve?domain=legal23bot"),
                        Choices = ChoiceFactory.ToChoices(new List<string> { "tg://resolve?domain=legal23bot"}),



                    };




                    return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.chooseAction", promptOptions, cancellationToken);

                }

                else
                {
                    var promptOptions = new PromptOptions
                    {
                        Prompt = MessageFactory.Text(" Go back to 444 the main menu")
                    };

                    return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.chooseAction", promptOptions, cancellationToken);

                }
           
        }



        private async Task<DialogTurnResult> SubCountyStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            stepContext.Values["county"] = (int)stepContext.Result;
            var json = File.ReadAllText(jsonFile);
            var counties = JsonConvert.DeserializeObject<List<County>>(json);

               
                int id = (int)stepContext.Values["county"];
              
                string sub_counties = "";
                for(int i =0; i<counties.Count; i++){ 
                    

                            if(counties[i].CountyId == id) 
                            {
                              for(int j = 0; j< counties[i].SubCounties.Length;j++){
                                   sub_counties += $"\n{j+1}.{counties[i].SubCounties[j].Name}\n";
                               }
                            }
                            
                } 
                
                
            if((string) stepContext.Values["preferredLanguage"] == "English"){
                
                var promptOptions = new PromptOptions{

                    Prompt = MessageFactory.Text("Which sub-county are you located at?\n" + sub_counties),
                    RetryPrompt = MessageFactory.Text("Please choose an option from the list."),
                   

                };
                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.subcounty",promptOptions, cancellationToken);
            }
            else {
               
                var promptOptions = new PromptOptions {
                    Prompt = MessageFactory.Text("Unaishi Katika sub-kaunti gani ?:\n"+ sub_counties),
                   RetryPrompt = MessageFactory.Text("Tafadhali chagua kutoka kwenye list"),

                };
                
                 return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.subcounty",promptOptions, cancellationToken);

            }
        }


        private async Task<DialogTurnResult> WardStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            // value we get back from the choice prompt
            stepContext.Values["subcounty"] = (int)stepContext.Result;
           



            if ((string) stepContext.Values["preferredLanguage"] == "English"){

              var promptOptions =  new PromptOptions
                {
                    Prompt = MessageFactory.Text("Which ward do you live? :\n" ),
                  RetryPrompt = MessageFactory.Text("Please choose an option from the list."),

              };
                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.ward",promptOptions,cancellationToken);
            }
            else {
                

               var promptOptions= new PromptOptions
                {
                    Prompt = MessageFactory.Text("Unaishi Katika Ward gani ?:\n"),
                    Choices = ChoiceFactory.ToChoices(new List<string> { "kiambu1", "Eldoret1", "Naivasha1", "Nakuru1", "MayCorn" }),

                };
                
                return await stepContext.PromptAsync($"{nameof(EnglishDetailsDialog)}.ward",promptOptions, cancellationToken);
            }
        }



    


            //value we get back from the choice prompt
            private async Task<DialogTurnResult> ConfirmationStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken) {
            stepContext.Values["ward"] = ((FoundChoice)stepContext.Result).Value;

            var userDetails= await _botStateService.UserDetailsAccessor.GetAsync(stepContext.Context, () => new UserDetails(), cancellationToken);

                 userDetails.Language = (string) stepContext.Values["preferredLanguage"];
                 userDetails.FullName = (string) stepContext.Values["name"];
                
                 userDetails.SubCounty = (string) stepContext.Values["subcounty"];
                 
                 userDetails.Ward = (string)stepContext.Values["ward"];
            // Show the summary to the user 
            if((string) stepContext.Values["preferredLanguage"] == "English"){
            await stepContext.Context.SendActivityAsync(MessageFactory.Text($" Congratulations {userDetails.FullName}! You are now" +
                $" registered to use our service.. Please choose (1. MAIN MENU) to continue using the service,"),cancellationToken);
            }
            else{
                await stepContext.Context.SendActivityAsync(MessageFactory.Text($" Karibu {userDetails.FullName}! tumekusajili" +
                $" Katika service yetu.. Tafadhali chagua (1. MAIN MENU) ndio uweze kuendelea kutumia service zetu...,"),cancellationToken);
            }
            
            await _botStateService.UserDetailsAccessor.SetAsync(stepContext.Context, userDetails);
             
             // waterfall step always finishes eith the end of the waterfall so here is where it ends

            return await stepContext.EndDialogAsync(cancellationToken: cancellationToken);
            }

        //Implementing Menu
        


    }
}
