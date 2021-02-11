using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Drawing;
using ClassLibrary7.reports;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;

namespace SLIC_Astra_Proposal
{
    class AstraNonPos: UnitTest1
    {
        public void Astra_NonPos()
        {
            //New_Customer
            start(); methodnamefiningfunction("Clicking New_Customer");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("tvWithOutAadhar1")));
            driver.FindElement(By.Id("tvWithOutAadhar1")).Click();
            End();

            //Title
            start(); methodnamefiningfunction("Clicking Title");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("salutationId1")));
            driver.FindElement(By.Id("salutationId1")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + LA_Title + "']")));
            driver.FindElement(By.XPath("//*[@text='" + LA_Title + "']")).Click();
            End();

            //First_Name
            start(); methodnamefiningfunction("Entering First_Name");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtFirstNameLA")));
            driver.FindElement(By.Id("edtFirstNameLA")).SendKeys(LA_First_Name);
            End();

            //Middle_Name
            start(); methodnamefiningfunction("Entering Middle_Name");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMiddleNameLA")));
            driver.FindElement(By.Id("edtMiddleNameLA")).SendKeys(LA_Middle_Name);
            End();

            //Last_Name
            start(); methodnamefiningfunction("Entering Last_Name");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtLastNameLA")));
            driver.FindElement(By.Id("edtLastNameLA")).SendKeys(LA_LastName);
            End();

            //DOB
            start(); methodnamefiningfunction("Clicking DOB");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalender")));
            driver.FindElement(By.Id("dateCalender")).Click();

            DOB(LA_Date);

            End();

            scroll("down");

            //Gender
            start(); methodnamefiningfunction("Clicking Gender");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("genderSpinIdLA")));
            driver.FindElement(By.Id("genderSpinIdLA")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + LA_Gender + "']")));
            driver.FindElement(By.XPath("//*[@text='" + LA_Gender + "']")).Click();
            End();

            //Marital_Status
            if (LA_Marital_Status != "")
            {
                start(); methodnamefiningfunction("Clicking Marital_Status");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("maritalSpinId")));
                driver.FindElement(By.Id("maritalSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + LA_Marital_Status + "']")));
                driver.FindElement(By.XPath("//*[@text='" + LA_Marital_Status + "']")).Click();
                End();
            }
            if (LA_Marital_Status == "Widow")
            {
                //Details_of_Children
                start(); methodnamefiningfunction("Entering Details_of_Children");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("widowchildqusspin")));
                driver.FindElement(By.Id("widowchildqusspin")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Details_of_Children + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Details_of_Children + "']")).Click();
                End();

                scroll("down");

                //Details_of_Children - Yes
                if (Details_of_Children == "Yes")
                {
                    string[] Children_Ages = Children_Age.Split(',');

                    int[] arr = new int[Children_Ages.Length];

                    for (int jj = 0; jj < arr.Length; jj++)
                    {
                        start(); methodnamefiningfunction("Entering Details_of_Children - Yes");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("addwidowchildApply")));
                        driver.FindElement(By.Id("addwidowchildApply")).Click();
                        End();

                        //Details_of_Children_Age
                        start(); methodnamefiningfunction("Entering Details_of_Children_Age");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("childdateCalender")));
                        driver.FindElement(By.Id("childdateCalender")).Click();
                        Details_of_Children_Age(Children_Ages[jj]);
                        End();

                        string[] Children_Genders = Children_Gender.Split(',');

                        //Details_of_Genders
                        start(); methodnamefiningfunction("Entering Details_of_Genders");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("widowchildgenderSpin")));
                        driver.FindElement(By.Id("widowchildgenderSpin")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Children_Genders[jj] + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Children_Genders[jj] + "']")).Click();
                        End();

                        string[] Children_Martial = Children_Martial_Status.Split(',');

                        //Children_Martial_Status
                        start(); methodnamefiningfunction("Entering Children_Martial_Status");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("widowchildmarySpin")));
                        driver.FindElement(By.Id("widowchildmarySpin")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Children_Martial[jj] + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Children_Martial[jj] + "']")).Click();
                        End();

                        //Children_Employment_Status

                        string[] Children_Employment = Children_Employment_Status.Split(',');

                        start(); methodnamefiningfunction("Entering Children_Martial_Status");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("widowchildoccspin")));
                        driver.FindElement(By.Id("widowchildoccspin")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Children_Employment[jj] + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Children_Employment[jj] + "']")).Click();
                        End();

                        //Children_Education
                        string[] Children_Educations = Children_Education.Split(',');

                        start(); methodnamefiningfunction("Entering Children_Martial_Status");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("widowchildeduspin")));
                        driver.FindElement(By.Id("widowchildeduspin")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Children_Educations[jj] + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Children_Educations[jj] + "']")).Click();
                        End();

                        //Save
                        start(); methodnamefiningfunction("Save");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnok")));
                        driver.FindElement(By.Id("btnok")).Click();
                        End();
                    }
                }
            }
            //Father_Name
            start(); methodnamefiningfunction("Entering Father_Name");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtFatherName")));
            driver.FindElement(By.Id("edtFatherName")).SendKeys(Father_Name);
            End();

            //LA_Aadhar_Number
            start(); methodnamefiningfunction("Entering LA_Aadhar_Number");

            //Aadhar1
            if (LA_Aadhar_Number != "")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Aadhrno3")));
                driver.FindElement(By.Id("Aadhrno3")).SendKeys(LA_Aadhar_Number);
                End();
            }

            scroll("halfdown");

            //PAN_Number
            if (LA_PAN_Number != "")
            {
                start(); methodnamefiningfunction("Entering PAN_Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtPANNO")));
                driver.FindElement(By.Id("edtPANNO")).SendKeys(LA_PAN_Number);
                End();
            }

            //Annual_Income
            start(); methodnamefiningfunction("Entering Annual_Income");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtSOI")));
            driver.FindElement(By.Id("edtSOI")).SendKeys(Annual_Income);
            End();
            if (LA_Marital_Status == "Married" || LA_Marital_Status == "Widow")
            {
                scroll("halfdown");
            }

            //Preferred Language for communication
            start(); methodnamefiningfunction("Selecting Preferred_Language");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("languageSpinId")));
            driver.FindElement(By.Id("languageSpinId")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Preferred_Language + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Preferred_Language + "']")).Click();
            End();

            //Nationality
            if (Nationality != "")
            {
                start(); methodnamefiningfunction("Entering Nationality");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nationSpinId")));
                driver.FindElement(By.Id("nationSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Nationality + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Nationality + "']")).Click();
                End();
            }

            scroll("halfdown");

            if (Nationality == "NRI")
            {
                //passport number
                start(); methodnamefiningfunction("Entering Passport Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edt_passport_number")));
                driver.FindElement(By.Id("edt_passport_number")).SendKeys(Passport_number);
                End();

                //Passport_expiry
                start(); methodnamefiningfunction("Entering Passport Expiry Date");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderPass")));
                driver.FindElement(By.Id("dateCalenderPass")).Click();

                Passportexpiry(Passport_expiry);
                End();

                scroll("down");

                //Country_of_Current_Residence
                start(); methodnamefiningfunction("Country_of_Current_Residence");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("countrySpinId")));
                driver.FindElement(By.Id("countrySpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Country_of_Current_Residence + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Country_of_Current_Residence + "']")).Click();
                End();

                //Purpose_of_Stay_in_Abroad
                start(); methodnamefiningfunction("Entering purpose of stay in abroad");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("purposeStaySpinId")));
                driver.FindElement(By.Id("purposeStaySpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Purpose_of_Stay_in_Abroad + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Purpose_of_Stay_in_Abroad + "']")).Click();
                End();

                //Date of coming India
                start(); methodnamefiningfunction("Entering Date of coming India");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("comingDateCalender")));
                driver.FindElement(By.Id("comingDateCalender")).Click();

                dateofcoming(date_of_coming);
                End();

                //Proposed_Date of Leaving India
                start(); methodnamefiningfunction("Entering Date of Leaving India");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("leavingDateCalender")));
                driver.FindElement(By.Id("leavingDateCalender")).Click();

                dateofleavingindia(Proposed_Date_of_Leaving_India);
                End();

                scroll("halfdown");

                //Bank_Name
                start(); methodnamefiningfunction("Entering Bank Name");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edt_bank_name")));
                driver.FindElement(By.Id("edt_bank_name")).SendKeys(NRI_Bank_Name);
                End();


                start(); methodnamefiningfunction("Entering Account Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edt_bank_acct_no")));
                driver.FindElement(By.Id("edt_bank_acct_no")).SendKeys(Account_Number);
                End();

                start(); methodnamefiningfunction("Entering Source");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edt_source_future_premiums")));
                driver.FindElement(By.Id("edt_source_future_premiums")).SendKeys(Source_from_which_future_Premiums_are_Paid);
                End();
                scroll("halfdown");
            }

            //PEP
            if (PEP == "Yes")
            {
                start(); methodnamefiningfunction("Clicking PEP");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("pepSwitch")));
                driver.FindElement(By.Id("pepSwitch")).Click();
                End();
            }

            //EIA
            if (EIA == "Yes")
            {
                start(); methodnamefiningfunction("Clicking EIA");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("eiaSwitch")));
                driver.FindElement(By.Id("eiaSwitch")).Click();
                End();

                scroll("halfdown");

                start(); methodnamefiningfunction("Entering EIA_Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtEiaNo")));
                driver.FindElement(By.Id("edtEiaNo")).SendKeys(EIA_Number);
                End();

                //Insurance_Repository
                start(); methodnamefiningfunction("Entering EIA_Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("insRepoName")));
                driver.FindElement(By.Id("insRepoName")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Insurance_Repository + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Insurance_Repository + "']")).Click();
                End();
            }

            //NRI_Country
            if (Nationality == "NRI")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nriSpinId")));
                driver.FindElement(By.Id("nriSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + NRI_Country + "']")));
                driver.FindElement(By.XPath("//*[@text='" + NRI_Country + "']")).Click();
            }

            if (FATCA == "Yes")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propfatcaSwitch")));
                driver.FindElement(By.Id("propfatcaSwitch")).Click();

                scroll("down");

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propothconSpinId")));
                driver.FindElement(By.Id("propothconSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Resident_Of_Any_country_outside + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Resident_Of_Any_country_outside + "']")).Click();

                if (Resident_Of_Any_country_outside == "Yes")
                {
                    //residence country outside
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propnriSpinId")));
                    driver.FindElement(By.Id("propnriSpinId")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + NRI_Resident_Country + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + NRI_Resident_Country + "']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propnriaddressEdt")));
                    driver.FindElement(By.Id("propnriaddressEdt")).SendKeys(NRI_Country_Address);

                }

                //Tax residence outside country
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptaxrescountSpinId")));
                driver.FindElement(By.Id("proptaxrescountSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Tax_Resident_Of_Any_country_outside + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Tax_Resident_Of_Any_country_outside + "']")).Click();

                scroll("halfdown");

                if (Tax_Resident_Of_Any_country_outside == "Yes")
                {
                    //Tax residence country outside
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptinisscountSpinId")));
                    driver.FindElement(By.Id("proptinisscountSpinId")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + TIN_Issues_country + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + TIN_Issues_country + "']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptinidEdt")));
                    driver.FindElement(By.Id("proptinidEdt")).SendKeys(TIN);

                    scroll("halfdown");
                }
                scroll("halfdown");
                //telephone jurisdiction outside india
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptelephoneSpinId")));
                driver.FindElement(By.Id("proptelephoneSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Holding_Telephone_Outside_India + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Holding_Telephone_Outside_India + "']")).Click();

                if (Holding_Telephone_Outside_India == "Yes")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propmobnoEdt")));
                    driver.FindElement(By.Id("propmobnoEdt")).SendKeys(Holding_Telephone_Outside_Mobile_Number);

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proplandlinenoEdt")));
                    driver.FindElement(By.Id("proplandlinenoEdt")).SendKeys(Holding_Telephone_Outside_Mobile_Number);

                    scroll("halfdown");
                }
                scroll("halfdown");
                //transfer fund outside

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propstandinstSpinId")));
                driver.FindElement(By.Id("propstandinstSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Transfer_Fund_Jurisdiction_outside_India + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Transfer_Fund_Jurisdiction_outside_India + "']")).Click();

                if (Transfer_Fund_Jurisdiction_outside_India == "Yes")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propstanddetEdt")));
                    driver.FindElement(By.Id("propstanddetEdt")).SendKeys(Transfer_Fund_Jurisdiction_outside_India_Detail);

                    scroll("halfdown");
                }

                //Signatory jurisditicon
                //transfer fund outside                   

                scroll("halfdown");

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propsignauthSpinId")));
                driver.FindElement(By.Id("propsignauthSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Signator_Authority_juridiction_outside_India + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Signator_Authority_juridiction_outside_India + "']")).Click();

                if (Signator_Authority_juridiction_outside_India == "Yes")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propsignautnameEdt")));
                    driver.FindElement(By.Id("propsignautnameEdt")).SendKeys(Signator_Authority_juridiction_outside_India_Name);

                    scroll("halfdown");

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propsignautaddrEdt")));
                    driver.FindElement(By.Id("propsignautaddrEdt")).SendKeys(Signator_Authority_juridiction_outside_India_Address);
                }
                scroll("halfdown");

                //hold mail                  
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propholdmailSpinId")));
                driver.FindElement(By.Id("propholdmailSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Hold_Mail_Jurisdiction_outside_India + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Hold_Mail_Jurisdiction_outside_India + "']")).Click();

                scroll("halfdown");

                if (Hold_Mail_Jurisdiction_outside_India == "Yes")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propholdmaildetEdt")));
                    driver.FindElement(By.Id("propholdmaildetEdt")).SendKeys(Hold_Mail_Jurisdiction_outside_India_Details);
                }
            }

            if (Life_Type == "For Other Life")
            {
                scroll("halfdown");

                //Proposer title
                if (Proposer_Title != "")
                {
                    start(); methodnamefiningfunction("Clicking Title");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("salutationId")));
                    driver.FindElement(By.Id("salutationId")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Proposer_Title + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Proposer_Title + "']")).Click();
                    End();
                }

                //First_Name
                start(); methodnamefiningfunction("Entering First_Name");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtFirstName")));
                driver.FindElement(By.Id("edtFirstName")).SendKeys(Proposer_Firstname);
                End();

                //Middle_Name
                start(); methodnamefiningfunction("Entering Middle_Name");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMiddleName")));
                driver.FindElement(By.Id("edtMiddleName")).SendKeys(Proposer_Middle_Name);
                End();

                //Last_Name
                start(); methodnamefiningfunction("Entering Last_Name");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtLastName")));
                driver.FindElement(By.Id("edtLastName")).SendKeys(Proposer_last_Name);
                End();

                scroll("halfdown");

                //DOB
                start(); methodnamefiningfunction("Clicking DOB");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalender1")));
                driver.FindElement(By.Id("dateCalender1")).Click();

                DOB1(Proposer_DOB);

                End();

                ////LA_Mobile_No
                //start(); methodnamefiningfunction("Entering Proposer Mobile_No");
                //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMobileNo")));
                //driver.FindElement(By.Id("edtMobileNo")).SendKeys(Proposer_Mobile_Number);
                //End();


                //LA_Aadhar_Number
                if (Proposer_Aadhaar_number != "")
                {
                    start(); methodnamefiningfunction("Entering Proposer Aadhar_Number");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("AadhrnoPro3")));
                    driver.FindElement(By.Id("AadhrnoPro3")).SendKeys(Proposer_Aadhaar_number);
                    End();
                }

                //relationship
                if (Proposer_relation != "")
                {
                    start(); methodnamefiningfunction("Clicking  Relationship");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("relationShipId")));
                    driver.FindElement(By.Id("relationShipId")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Proposer_relation + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Proposer_relation + "']")).Click();
                    End();
                }

                scroll("down");

                //PAN_Number
                start(); methodnamefiningfunction("Entering PAN_Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propedtPANNO")));
                driver.FindElement(By.Id("propedtPANNO")).SendKeys(Proposer_PAN_Number);
                End();


                //occupation
                start(); methodnamefiningfunction("Clicking occupation");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propoccupationSpinIdd")));
                driver.FindElement(By.Id("propoccupationSpinIdd")).SendKeys(Proposer_Occupation);
                End();

                //Annual_Income
                start(); methodnamefiningfunction("Entering Annual_Income");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propedtSOI")));
                driver.FindElement(By.Id("propedtSOI")).SendKeys(Proposer_Annual_Income);
                End();

                //Nationality
                if (Proposer_Nationality != "")
                {
                    start(); methodnamefiningfunction("Clicking Nationality");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propnationSpinId")));
                    driver.FindElement(By.Id("propnationSpinId")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Proposer_Nationality + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Proposer_Nationality + "']")).Click();
                    End();
                }

                if (Nationality == "NRI")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nriSpinId")));
                    driver.FindElement(By.Id("nriSpinId")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + NRI_Country + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + NRI_Country + "']")).Click();

                    if (FATCA == "Yes")
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propfatcaSwitch")));
                        driver.FindElement(By.Id("propfatcaSwitch")).Click();

                        scroll("down");

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propothconSpinId")));
                        driver.FindElement(By.Id("propothconSpinId")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Resident_Of_Any_country_outside + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Resident_Of_Any_country_outside + "']")).Click();

                        if (Resident_Of_Any_country_outside == "Yes")
                        {
                            //residence country outside
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propnriSpinId")));
                            driver.FindElement(By.Id("propnriSpinId")).Click();

                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + NRI_Country + "']")));
                            driver.FindElement(By.XPath("//*[@text='" + NRI_Country + "']")).Click();

                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propnriaddressEdt")));
                            driver.FindElement(By.Id("propnriaddressEdt")).SendKeys(NRI_Country_Address);
                        }

                        scroll("down");

                        //Tax residence outside country
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptaxrescountSpinId")));
                        driver.FindElement(By.Id("proptaxrescountSpinId")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Resident_Of_Any_country_outside + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Resident_Of_Any_country_outside + "']")).Click();

                        if (Tax_Resident_Of_Any_country_outside == "Yes")
                        {
                            //Tax residence country outside
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptinisscountSpinId")));
                            driver.FindElement(By.Id("proptinisscountSpinId")).Click();

                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + TIN_Issues_country + "']")));
                            driver.FindElement(By.XPath("//*[@text='" + TIN_Issues_country + "']")).Click();

                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptinidEdt")));
                            driver.FindElement(By.Id("proptinidEdt")).SendKeys(TIN);
                            scroll("halfdown");
                        }

                        //telephone jurisdiction outside india
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proptelephoneSpinId")));
                        driver.FindElement(By.Id("proptelephoneSpinId")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Holding_Telephone_Outside_India + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Holding_Telephone_Outside_India + "']")).Click();

                        if (Holding_Telephone_Outside_India == "Yes")
                        {
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propmobnoEdt")));
                            driver.FindElement(By.Id("propmobnoEdt")).SendKeys(Holding_Telephone_Outside_Mobile_Number);

                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proplandlinenoEdt")));
                            driver.FindElement(By.Id("proplandlinenoEdt")).SendKeys(Holding_Telephone_Outside_Mobile_Number);
                            scroll("halfdown");
                        }

                        //transfer fund outside
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propstandinstSpinId")));
                        driver.FindElement(By.Id("propstandinstSpinId")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Transfer_Fund_Jurisdiction_outside_India + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Transfer_Fund_Jurisdiction_outside_India + "']")).Click();

                        if (Transfer_Fund_Jurisdiction_outside_India == "Yes")
                        {
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propstanddetEdt")));
                            driver.FindElement(By.Id("propstanddetEdt")).SendKeys(Transfer_Fund_Jurisdiction_outside_India_Detail);
                            scroll("halfdown");
                        }

                        //Signatory jurisditicon
                        //transfer fund outside
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propsignauthSpinId")));
                        driver.FindElement(By.Id("propsignauthSpinId")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Signator_Authority_juridiction_outside_India + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Signator_Authority_juridiction_outside_India + "']")).Click();

                        if (Signator_Authority_juridiction_outside_India == "Yes")
                        {
                            scroll("halfdown");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propsignautnameEdt")));
                            driver.FindElement(By.Id("propsignautnameEdt")).SendKeys(Signator_Authority_juridiction_outside_India_Name);

                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propsignautaddrEdt")));
                            driver.FindElement(By.Id("propsignautaddrEdt")).SendKeys(Signator_Authority_juridiction_outside_India_Address);
                            scroll("down");
                        }

                        //hold mail
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propholdmailSpinId")));
                        driver.FindElement(By.Id("propholdmailSpinId")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Hold_Mail_Jurisdiction_outside_India + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Hold_Mail_Jurisdiction_outside_India + "']")).Click();
                        Thread.Sleep(500);

                        scroll("down");

                        if (Hold_Mail_Jurisdiction_outside_India == "Yes")
                        {
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("propholdmaildetEdt")));
                            driver.FindElement(By.Id("propholdmaildetEdt")).SendKeys(Hold_Mail_Jurisdiction_outside_India_Details);
                        }
                    }
                }
            }

            //Next
            start(); methodnamefiningfunction("Clicking Next");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
            driver.FindElement(By.Id("btsubmit")).Click();
            End();

            //PLAN & RIDER DETAILS

            //Plan_Name
            start(); methodnamefiningfunction("Clicking Plan_Name");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("plantype")));
            driver.FindElement(By.Id("plantype")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Plan_Name + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Plan_Name + "']")).Click();
            End();

            if (Plan_Name == "SHRIRAM LIFE ASSURED ADVANTAGE PLUS V02")
            {
                scroll("up");
            }

            //Objective_of_Insurance
            start(); methodnamefiningfunction("Selecting Objective_of_Insurance");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("insuranceobjective")));
            driver.FindElement(By.Id("insuranceobjective")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Objective_of_Insurance + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Objective_of_Insurance + "']")).Click();
            End();
            
            if (Plan_Name == "SHRIRAM NEW SHRI LIFE PLAN V02" || Plan_Name == "SHRIRAM LIFE SUPER INCOME PLAN V02")
            {
                //Age_Proof_Type
                if (Age_Proof != "")
                {
                    start(); methodnamefiningfunction("Clicking Age_Proof_Type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                    driver.FindElement(By.Id("proAgeProof")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                    End();
                }

                scroll("down");

                //Policy_Term
                if (Policy_Term != "")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                    driver.FindElement(By.Id("policyterm")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                    }
                    catch
                    {
                        driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                    }

                    End();
                }

                //Premium_Term
                if (Premium_Term != "")
                {
                    start(); methodnamefiningfunction("Clicking Premium_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("premiumValidate")));
                    driver.FindElement(By.Id("premiumValidate")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                              + "new UiSelector().text(\"" + Premium_Term + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Premium_Term + "']")).Click(); }

                    End();
                }

                //Premium_Mode
                if (Premium_Mode != "")
                {
                    start(); methodnamefiningfunction("Clicking Premium_Mode");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                    driver.FindElement(By.Id("permode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                    End();
                }
                scroll("halfdown");

                //Sum_Assured
                if (Plan_Name == "SHRIRAM NEW SHRI LIFE PLAN V02")
                {
                    start(); methodnamefiningfunction("Entering Sum_Assured");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sumpro")));
                    driver.FindElement(By.Id("sumpro")).SendKeys(Sum_Assured);
                    End();
                }
                else if (Plan_Name == "SHRIRAM LIFE SUPER INCOME PLAN V02")
                {
                    start(); methodnamefiningfunction("Entering Sum_Assured");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("periumamount")));
                    driver.FindElement(By.Id("periumamount")).SendKeys(AssuredIncome_AnnualPremium);
                    End();
                }

                if (Plan_Name == "SHRIRAM NEW SHRI LIFE    V02")
                {
                    //Family_Income
                    if (Family_Income == "Yes")
                    {
                        start(); methodnamefiningfunction("Clicking Family_Income");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")));
                        driver.FindElement(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                        driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                        End();
                    }
                    if (Shriram_Extra_Insurance == "Yes")
                    {
                        start(); methodnamefiningfunction("Clicking Shriram_Extra_Insurance");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")));
                        driver.FindElement(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                        driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                        End();
                    }

                    //Accident_Benefit
                    if (Accident_Benefit == "Yes")
                    {
                        start(); methodnamefiningfunction("Clicking Accident_Benefit");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")));
                        driver.FindElement(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                        driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                        End();
                    }
                }

                scroll("halfdown");

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();
                Thread.Sleep(2000);

                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //
                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }

            if (Plan_Name == "SHRIRAM LIFE ASSURED INCOME PLAN V03")
            {
                //Maturity
                start(); methodnamefiningfunction("Entering Maturity");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("lifeCoversts")));
                driver.FindElement(By.Id("lifeCoversts")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Maturity_Benefit + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Maturity_Benefit + "']")).Click();
                End();

                if (Maturity_Benefit == "Payout")
                {
                    //Maturity_Benefit
                    start(); methodnamefiningfunction("Entering Maturity_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permodeLifeCover")));
                    driver.FindElement(By.Id("permodeLifeCover")).Click();

                    //
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Maturity_PayoutMode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Maturity_PayoutMode + "']")).Click();
                    End();
                }

                scroll("halfdown");

                //Death
                start(); methodnamefiningfunction("Entering Death");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("lifedeathCoversts")));
                driver.FindElement(By.Id("lifedeathCoversts")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Death_Benefit + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Death_Benefit + "']")).Click();
                End();

                if (Death_Benefit == "Payout" || Death_Benefit == "Both")
                {
                    //Death_PayoutMode
                    start(); methodnamefiningfunction("Entering Death_PayoutMode");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permodedeathLifeCover")));
                    driver.FindElement(By.Id("permodedeathLifeCover")).Click();

                    //
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Death_PayoutMode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Death_PayoutMode + "']")).Click();
                    End();
                }
                scroll("halfdown");

                if (Age_Proof != "")
                {
                    //Age_Proof Type
                    start(); methodnamefiningfunction("Entering Age_Proof");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                    driver.FindElement(By.Id("proAgeProof")).Click();
                    Thread.Sleep(500);

                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                    End();
                }

                scroll("down");

                if (Policy_Term != "")
                {
                    //Policy_Term
                    start(); methodnamefiningfunction("Entering Policy_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                    driver.FindElement(By.Id("policyterm")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                    }
                    catch
                    {
                        driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                    }
                    End();
                }

                scroll("down");


                if (Premium_Mode != "")
                {
                    //Premium_mode
                    start(); methodnamefiningfunction("Entering Premium_mode");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                    driver.FindElement(By.Id("permode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                    End();
                }

                //Accident_Benefit
                if (Accident_Benefit == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Accident_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='ACCIDENT BENEFIT RIDER V02']")));
                    driver.FindElement(By.XPath("//*[@text='ACCIDENT BENEFIT RIDER V02']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                //Family_Income
                if (Family_Income == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Family_Income");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                if (Shriram_Extra_Insurance == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Extra_Insurance");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                scroll("down");

                //Annual_Premium
                start(); methodnamefiningfunction("Entering Annual_Premium");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("periumamount")));
                driver.FindElement(By.Id("periumamount")).SendKeys(AssuredIncome_AnnualPremium);
                End();

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();

                Thread.Sleep(2000);

                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }

            if (Plan_Name == "SHRIRAM LIFE GENIUS ASSURED BENEFIT PLAN V02")
            {
                //Maturity_Benefit
                if (Genius_Maturity_Benefit != "")
                {
                    start(); methodnamefiningfunction("Entering Maturity_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("maturSpin")));
                    driver.FindElement(By.Id("maturSpin")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Genius_Maturity_Benefit + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Genius_Maturity_Benefit + "']")).Click();
                    End();
                }
                scroll("down");

                //Death_Benefit
                if (Genius_Death_Benefit != "")
                {
                    start(); methodnamefiningfunction("Entering Death_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("deathSpin")));
                    driver.FindElement(By.Id("deathSpin")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Genius_Death_Benefit + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Genius_Death_Benefit + "']")).Click();
                    End();
                }

                if (Genius_Death_Benefit == "INSTALLMENT")
                {
                    //Educational_Benefit
                    start(); methodnamefiningfunction("Entering Educational_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("educationSpin")));
                    driver.FindElement(By.Id("educationSpin")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Educational_Benefit + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Educational_Benefit + "']")).Click();
                    End();
                }
                //Age_Proof Type
                if (Age_Proof != "")
                {
                    start(); methodnamefiningfunction("Entering Age_Proof");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                    driver.FindElement(By.Id("proAgeProof")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                    End();
                }
                scroll("halfdown");
                //Policy_Term
                if (Policy_Term != "")
                {
                    start(); methodnamefiningfunction("Entering Policy_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                    driver.FindElement(By.Id("policyterm")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                    }
                    catch
                    {
                        driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                    }
                    End();
                }

                scroll("down");
                //Premium_Term
                if (Premium_Term != "")
                {
                    start(); methodnamefiningfunction("Entering Premium_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("premiumValidate")));
                    driver.FindElement(By.Id("premiumValidate")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                              + "new UiSelector().text(\"" + Premium_Term + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Premium_Term + "']")).Click(); }

                    End();
                }
                if (Genius_Death_Benefit == "INSTALLMENT")
                {
                    scroll("halfdown");
                }
                //Premium_mode
                if (Premium_Mode != "")
                {
                    start(); methodnamefiningfunction("Entering Premium_mode");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                    driver.FindElement(By.Id("permode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                    End();
                }
                scroll("down");

                //Sum_Assured
                start(); methodnamefiningfunction("Entering Sum_Assured");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sumpro")));
                driver.FindElement(By.Id("sumpro")).SendKeys(Sum_Assured);
                End();

                //Accident_Benefit
                if (Accident_Benefit == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Accident_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='ACCIDENT BENEFIT RIDER V02']")));
                    driver.FindElement(By.XPath("//*[@text='ACCIDENT BENEFIT RIDER V02']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                scroll("down");

                if (Shriram_Critical == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Critical");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM CRITICAL ILLNESS COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM CRITICAL ILLNESS COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                if (Shriram_Extra_Insurance == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Extra_Insurance");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                //Family_Income
                if (Family_Income == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Family_Income");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='FAMILY INCOME BENEFIT RIDER V02']")));
                    driver.FindElement(By.XPath("//*[@text='FAMILY INCOME BENEFIT RIDER V02']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();
                Thread.Sleep(1000);

                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();

                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }

            if(Plan_Name == "SHRIRAM LIFE ASSURED INCOME PLUS V02")
            {
                //Age_Proof Type
                if (Age_Proof != "")
                {
                    start(); methodnamefiningfunction("clicking age proof");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                    driver.FindElement(By.Id("proAgeProof")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                    End();
                }
                scroll("halfdown");
                //Policy_Term
                if (Policy_Term != "")
                {
                    start(); methodnamefiningfunction("clicking policy term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                    driver.FindElement(By.Id("policyterm")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                    }
                    catch
                    {
                        driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                    }
                    End();
                }
                //Premium_mode
                if (Premium_Mode != "")
                {
                    start(); methodnamefiningfunction("clicking premium mode");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                    driver.FindElement(By.Id("permode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                    End();
                }
                scroll("down");
                //Sum_Assured
                start(); methodnamefiningfunction("Entering sum assured");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sumpro")));
                driver.FindElement(By.Id("sumpro")).SendKeys(Sum_Assured);
                End();

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();
                Thread.Sleep(2000);
                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //
                //Permanent_Address
                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }

            if (Plan_Name == "SHRIRAM NEW AKSHAY NIDHI V02")
            {
                //Age_Proof_Type
                start(); methodnamefiningfunction("Clicking Age_Proof_Type");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                driver.FindElement(By.Id("proAgeProof")).Click();
                Thread.Sleep(500);
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                      + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                }
                catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                End();

                //Policy_Term
                start(); methodnamefiningfunction("Clicking Policy_Term");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                driver.FindElement(By.Id("policyterm")).Click();
                Thread.Sleep(500);
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                      + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                }
                catch
                {
                    driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                }
                End();

                scroll("down");

                ////Premium_Term
                //start(); methodnamefiningfunction("Clicking Premium_Term");
                //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("premiumValidate")));
                //driver.FindElement(By.Id("premiumValidate")).Click();

                //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Term + "']")));
                //driver.FindElement(By.XPath("//*[@text='" + Premium_Term + "']")).Click();
                //End();

                //Premium_Mode
                start(); methodnamefiningfunction("Clicking Premium_Mode");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                driver.FindElement(By.Id("permode")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                End();

                //Sum_Assured
                start(); methodnamefiningfunction("Entering Sum_Assured");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sumpro")));
                driver.FindElement(By.Id("sumpro")).SendKeys(Sum_Assured);
                End();

                scroll("halfdown");

                //Accident_Benefit
                if (Accident_Benefit == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Accident_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                if (Shriram_Critical == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Critical");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM CRITICAL ILLNESS COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM CRITICAL ILLNESS COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                scroll("down");

                if (Shriram_Extra_Insurance == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Extra_Insurance");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                //Family_Income
                if (Family_Income == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Family_Income");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                Thread.Sleep(2000);

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();
                Thread.Sleep(2000);
                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();
                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                //Medical Details
                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //
                //Permanent_Address
                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }

            if (Plan_Name == "SHRIRAM NEW SHRI VIDYA V02" || Plan_Name == "SHRIRAM LIFE GOLDEN PREMIER SAVER PLAN")
            {
                if (Plan_Name == "SHRIRAM LIFE GOLDEN PREMIER SAVER PLAN")
                {
                    start(); methodnamefiningfunction("Clicking Age_Proof_Type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("lifeCoversts")));
                    driver.FindElement(By.Id("lifeCoversts")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Maturity_Benefit + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Maturity_Benefit + "']")).Click();
                    End();

                    scroll("halfdown");
                }

                //Age_Proof_Type
                if (Age_Proof != "")
                {
                    start(); methodnamefiningfunction("Clicking Age_Proof_Type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                    driver.FindElement(By.Id("proAgeProof")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                    End();
                }
                scroll("halfdown");
                //Policy_Term
                if (Policy_Term != "")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                    driver.FindElement(By.Id("policyterm")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                    }
                    catch
                    {
                        driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                    }
                    End();
                }

                scroll("down");

                //Premium_Term
                if (Premium_Term != "")
                {
                    start(); methodnamefiningfunction("Clicking Premium_Term");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("premiumValidate")));
                    driver.FindElement(By.Id("premiumValidate")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                              + "new UiSelector().text(\"" + Premium_Term + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Premium_Term + "']")).Click(); }

                    End();
                }

                //Premium_Mode
                if (Premium_Mode != "")
                {
                    start(); methodnamefiningfunction("Clicking Premium_Mode");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                    driver.FindElement(By.Id("permode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                    End();
                }
                scroll("halfdown");

                //Sum_Assured
                start(); methodnamefiningfunction("Entering Sum_Assured");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sumpro")));
                driver.FindElement(By.Id("sumpro")).SendKeys(Sum_Assured);
                End();

                //Accident_Benefit
                if (Accident_Benefit == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Accident_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                if (Family_Income == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Family_Income");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM FAMILY INCOME BENEFIT RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                if (Shriram_Extra_Insurance == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Extra_Insurance");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                Thread.Sleep(1000);
                End();
                Thread.Sleep(4000);

                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.google.android.apps.docs:id/action_find")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                //Medical Details
                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //
                //Permanent_Address
                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details
                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }


            if (Plan_Name == "SHRIRAM LIFE ASSURED ADVANTAGE PLUS V02")
            {
                //Age_Proof_Type
                start(); methodnamefiningfunction("Clicking Age_Proof_Type");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                driver.FindElement(By.Id("proAgeProof")).Click();
                Thread.Sleep(500);
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                      + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                }
                catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                End();

                scroll("up");

                //Life_Cover_Type
                start(); methodnamefiningfunction("Clicking Life_Cover_Type");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("SpinLifeCover")));
                driver.FindElement(By.Id("SpinLifeCover")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Life_Cover_Type + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Life_Cover_Type + "']")).Click();
                End();

                scroll("up");

                //Maturity/Death_Benefit
                start(); methodnamefiningfunction("Clicking MaturityDeath_Benefit");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("SpinPayOut")));
                driver.FindElement(By.Id("SpinPayOut")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + MaturityDeath_Benefit + "']")));
                driver.FindElement(By.XPath("//*[@text='" + MaturityDeath_Benefit + "']")).Click();
                End();

                //Policy_Term
                start(); methodnamefiningfunction("Clicking Policy_Term");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                driver.FindElement(By.Id("policyterm")).Click();
                Thread.Sleep(500);
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                      + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                }
                catch
                {
                    driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                }
                End();

                ////Premium_Term
                //start(); methodnamefiningfunction("Clicking Premium_Term");
                //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("premiumValidate")));
                //driver.FindElement(By.Id("premiumValidate")).Click();

                //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Term + "']")));
                //driver.FindElement(By.XPath("//*[@text='" + Premium_Term + "']")).Click();
                //End();
                scroll("halfdown");

                //Premium_Mode
                start(); methodnamefiningfunction("Clicking Premium_Mode");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                driver.FindElement(By.Id("permode")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                End();


                //Single_premium
                start(); methodnamefiningfunction("Entering Single_premium");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("periumamount")));
                driver.FindElement(By.Id("periumamount")).SendKeys(Single_Premium);
                End();

                Thread.Sleep(2000);

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                //Medical Details

                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //
                //Permanent_Address
                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }

            if (Plan_Name == "SHRIRAM LIFE ASSURED INCOME PLUS V03")
            {
                //Age_Proof_Type
                if (Age_Proof != "")
                {
                    start(); methodnamefiningfunction("Clicking Age_Proof_Type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAgeProof")));
                    driver.FindElement(By.Id("proAgeProof")).Click();
                    Thread.Sleep(500);
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Age_Proof + "\"));").Click();
                    }
                    catch { driver.FindElement(By.XPath("//*[@text='" + Age_Proof + "']")).Click(); }

                    End();
                }
                scroll("down");

                //Policy_Term
                start(); methodnamefiningfunction("Clicking Policy_Term");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("policyterm")));
                driver.FindElement(By.Id("policyterm")).Click();
                Thread.Sleep(500);
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                      + "new UiSelector().text(\"" + Policy_Term + "\"));").Click();
                }
                catch
                {
                    driver.FindElement(By.XPath("//*[@text='" + Policy_Term + "']")).Click();
                }
                End();

                //Premium_Term
                start(); methodnamefiningfunction("Clicking Premium_Term");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("premiumValidate")));
                driver.FindElement(By.Id("premiumValidate")).Click();
                Thread.Sleep(500);
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                          + "new UiSelector().text(\"" + Premium_Term + "\"));").Click();
                }
                catch { driver.FindElement(By.XPath("//*[@text='" + Premium_Term + "']")).Click(); }

                End();

                //Premium_Mode
                start(); methodnamefiningfunction("Clicking Premium_Mode");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("permode")));
                driver.FindElement(By.Id("permode")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Premium_Mode + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Premium_Mode + "']")).Click();
                End();

                scroll("halfdown");

                //Sum_Assured
                start(); methodnamefiningfunction("Entering Sum_Assured");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sumpro")));
                driver.FindElement(By.Id("sumpro")).SendKeys(Sum_Assured);
                End();


                //Accident_Benefit
                if (Accident_Benefit == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Accident_Benefit");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM ACCIDENT BENEFIT RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                if (Shriram_Extra_Insurance == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Extra_Insurance");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM EXTRA INSURANCE COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                scroll("down");

                if (Shriram_Critical == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Shriram_Critical");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SHRIRAM CRITICAL ILLNESS COVER RIDER V03']")));
                    driver.FindElement(By.XPath("//*[@text='SHRIRAM CRITICAL ILLNESS COVER RIDER V03']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }

                //Calculate
                start(); methodnamefiningfunction("Clicking Calculate");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("calculateButton")));
                driver.FindElement(By.Id("calculateButton")).Click();
                End();

                Thread.Sleep(4000);
                scroll("down");
                scroll("down");

                //ILLUSTRATION
                start(); methodnamefiningfunction("Clicking Illustration");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("IllustrationButton")));
                driver.FindElement(By.Id("IllustrationButton")).Click();
                End();

                Thread.Sleep(10000);
                try
                {
                    try
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/url_bar")));
                        driver.Navigate().Back();
                    }

                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("com.android.chrome:id/button_secondary")));
                        driver.FindElement(By.Id("com.android.chrome:id/button_secondary")).Click();
                        driver.Navigate().Back();
                    }
                }
                catch { driver.Navigate().Back(); }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                try
                {
                    start(); methodnamefiningfunction("Clicking OK");
                    waity.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
                    driver.FindElement(By.XPath("//*[@text='OK']")).Click();
                    End();
                }
                catch { }

                if (Policy_Sourced_by == "No")
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOther")));
                    driver.FindElement(By.Id("gdOther")).Click();
                    End();

                    //Source_Code
                    start(); methodnamefiningfunction("Clicking Source_Code");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("sCode")));
                    driver.FindElement(By.Id("sCode")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Source_Code + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Source_Code + "']")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Policy_Sourced_by");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("gdOwn")));
                    driver.FindElement(By.Id("gdOwn")).Click();
                    End();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Confirm
                start(); methodnamefiningfunction("Clicking Confirm");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CONFIRM']")));
                driver.FindElement(By.XPath("//*[@text='CONFIRM']")).Click();
                End();

                //Medical Details

                Medical_Details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //
                //Permanent_Address
                start(); methodnamefiningfunction("Entering Door_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edtpermStreetName")));
                driver.FindElement(By.Id("edtpermStreetName")).Click();
                driver.FindElement(By.Id("edtpermStreetName")).SendKeys(Door_No_Permanent_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtpermStreetName2")));
                driver.FindElement(By.Id("edtpermStreetName2")).SendKeys(Street_Permanent_Address);
                End();
                Communication_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Other_details();

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                //Nominee_Details

                if (Life_Type == "For Own Life")
                {
                    Nominee_Details();
                }

                //Next
                start(); methodnamefiningfunction("Clicking Next");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
                driver.FindElement(By.Id("btsubmit")).Click();
                End();

                Document_Upload();

                //DONE
                start(); methodnamefiningfunction("Entering DONE");
                wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DONE']")));
                Capture();
                driver.FindElement(By.XPath("//*[@text='DONE']")).Click();
                End();
            }
        }
    }
}
