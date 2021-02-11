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
    class AstraPOS: UnitTest1
    {       
        public void Pos_category()
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

            scroll("halfdown");

            //Nature_of_Duties
            start(); methodnamefiningfunction("Selecting Nature_of_Duties");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("naturalSpinId")));
            driver.FindElement(By.Id("naturalSpinId")).Click();
            try
            {
                driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                   + "new UiSelector().text(\"" + Nature_of_Duties + "\"));").Click();
     
            } catch {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Nature_of_Duties + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Nature_of_Duties + "']")).Click();
            }
            
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

            if (Nationality == "NRI")
            {
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nriSpinId")));
                driver.FindElement(By.Id("nriSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + NRI_Country + "']")));
                driver.FindElement(By.XPath("//*[@text='" + NRI_Country + "']")).Click();
            }

            //Preferred Language for communication
            start(); methodnamefiningfunction("Selecting Preferred_Language");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("languageSpinId")));
            driver.FindElement(By.Id("languageSpinId")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Preferred_Language + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Preferred_Language + "']")).Click();
            End();

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
            }

            //Next
            start(); methodnamefiningfunction("Clicking Next");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
            driver.FindElement(By.Id("btsubmit")).Click();
            End();

            //Plan_Name
            start(); methodnamefiningfunction("Clicking Plan_Name");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("plantype")));
            driver.FindElement(By.Id("plantype")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Plan_Name + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Plan_Name + "']")).Click();
            End();

            //Objective_of_Insurance
            start(); methodnamefiningfunction("Selecting Objective_of_Insurance");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("insuranceobjective")));
            driver.FindElement(By.Id("insuranceobjective")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Objective_of_Insurance + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Objective_of_Insurance + "']")).Click();
            End();

            if(Plan_Name == "SHRIRAM LIFE ASSURED INCOME PLAN POS")
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

                if (Smoke == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Tobocco");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiosmyes")));
                    driver.FindElement(By.Id("radiosmyes")).Click();

                    //Smoke_Type
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("spinsmoketype")));
                    driver.FindElement(By.Id("spinsmoketype")).Click();
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Smoke_Type + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Smoke_Type + "']")).Click();

                    scroll("halfdown");

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsmYes")));
                    driver.FindElement(By.Id("edtsmYes")).Click();
                    driver.FindElement(By.Id("edtsmYes")).SendKeys(Smoke_Quantity);
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Tobocco");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiosmno")));
                    driver.FindElement(By.Id("radiosmno")).Click();
                    End();
                }


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

            }

            if (Plan_Name == "SHRIRAM LIFE POS ASSURED SAVINGS PLAN")
            {
                //Life_Cover_Type
                start(); methodnamefiningfunction("Clicking Life_Cover_Type");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("SpinLifeCover")));
                driver.FindElement(By.Id("SpinLifeCover")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Life_Cover_Type + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Life_Cover_Type + "']")).Click();
                End();

                scroll("halfdown");

                if (Smoke == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking Tobocco");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiosmyes")));
                    driver.FindElement(By.Id("radiosmyes")).Click();

                    //Smoke_Type
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("spinsmoketype")));
                    driver.FindElement(By.Id("spinsmoketype")).Click();
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Smoke_Type + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Smoke_Type + "']")).Click();

                    scroll("halfdown");

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsmYes")));
                    driver.FindElement(By.Id("edtsmYes")).Click();
                    driver.FindElement(By.Id("edtsmYes")).SendKeys(Smoke_Quantity);
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Clicking Tobocco");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiosmno")));
                    driver.FindElement(By.Id("radiosmno")).Click();
                    End();
                }

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
            }

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
            //Weight
            start(); methodnamefiningfunction("Entering Weight");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtweight")));
            driver.FindElement(By.Id("edtweight")).SendKeys(Weight);
            End();

            //Height
            start(); methodnamefiningfunction("Entering Height");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("heightFeet")));
            driver.FindElement(By.Id("heightFeet")).Click();
            driver.FindElement(By.Id("heightFeet")).SendKeys(Height_FT);

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("heightInch")));
            driver.FindElement(By.Id("heightInch")).Click();
            driver.FindElement(By.Id("heightInch")).SendKeys(Height_Inches);
            End();

            if (Alcohol == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Alcohol");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioalyes")));
                driver.FindElement(By.Id("radioalyes")).Click();

                scroll("halfdown");

                //Alcohol_Type
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("spinalcoholtype")));
                driver.FindElement(By.Id("spinalcoholtype")).Click();
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Alcohol_Type + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Alcohol_Type + "']")).Click();

                Thread.Sleep(500);
                scroll("halfdown");

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtalYes")));
                driver.FindElement(By.Id("edtalYes")).Click();
                driver.FindElement(By.Id("edtalYes")).SendKeys(Alcohol_Quantity);
                End();
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Alcohol");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioalno")));
                driver.FindElement(By.Id("radioalno")).Click();
                scroll("halfdown");
                End();
            }

            if (Defect_or_Deformity == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Bodily_defect");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodeyes")));
                driver.FindElement(By.Id("radiodeyes")).Click();

                scroll("halfdown");

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtdeformityDetails")));
                driver.FindElement(By.Id("edtdeformityDetails")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Deformity_Type + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Deformity_Type + "']")).Click();
                End();
                Thread.Sleep(500);

                //Percentage_of_Disability
                start(); methodnamefiningfunction("Clicking Percentage_of_Disability");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtdeformityYespercent")));
                driver.FindElement(By.Id("edtdeformityYespercent")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Percentage_of_Disability + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Percentage_of_Disability + "']")).Click();
                End();

                //Deformity_Reason
                start(); methodnamefiningfunction("Clicking Deformity_Reason");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtdeformityYestype")));
                driver.FindElement(By.Id("edtdeformityYestype")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Deformity_Reason + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Deformity_Reason + "']")).Click();
                End();

                scroll("halfdown");

                //Walk_with_aid
                start(); methodnamefiningfunction("Clicking Walk_with_aid");
                if (Walk_with_aid == "Yes")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodewalkyes")));
                    driver.FindElement(By.Id("radiodewalkyes")).Click();
                }
                else
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodewalkno")));
                    driver.FindElement(By.Id("radiodewalkno")).Click();
                }
                End();

                scroll("halfdown");

                //Limbs_Affected
                start(); methodnamefiningfunction("Clicking Limbs_Affected");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtdeformityYeslimbs")));
                driver.FindElement(By.Id("edtdeformityYeslimbs")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Limbs_Affected + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Limbs_Affected + "']")).Click();
                End();
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Bodily_defect");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodeno")));
                driver.FindElement(By.Id("radiodeno")).Click();
                End();
            }

            //scroll("halfdown");

            if (Treated_For_Any_Illness == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Treated_For_Any_Illness");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioillyes")));
                driver.FindElement(By.Id("radioillyes")).Click();

                //Remarks
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtillYes")));
                driver.FindElement(By.Id("edtillYes")).Click();
                driver.FindElement(By.Id("edtillYes")).SendKeys(Treated_For_Any_Illness_Provide_Details);
                End();
                scroll("halfdown");
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Treated_For_Any_Illness");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioillno")));
                driver.FindElement(By.Id("radioillno")).Click();
                End();
                scroll("halfdown");
            }

            if (LA_Gender == "Female")
            {
                //Gynaecological_Disorder
                if (Currently_Pregnant == "Yes")
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Gynaecological_Disorder");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rgGynaecologicalYes")));
                    driver.FindElement(By.Id("rgGynaecologicalYes")).Click();
                    End();

                    scroll("halfdown");

                    //Remarks-Number_of_weeks_of_Pregnancy
                    start(); methodnamefiningfunction("Entering Remark");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtGynaecologicalDetails")));
                    driver.FindElement(By.Id("edtGynaecologicalDetails")).Click();
                    driver.FindElement(By.Id("edtGynaecologicalDetails")).SendKeys(Remarks_for_Pregnant);
                    End();
                }
                else
                {
                    //No
                    start(); methodnamefiningfunction("Entering No");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rgGynaecologicalNo")));
                    driver.FindElement(By.Id("rgGynaecologicalNo")).Click();
                    End();
                }
            }
                    //Covid-19
                    try
                    {
                        if (Covid_Quarantined == "Yes")
                        {
                            //Yes   
                            start(); methodnamefiningfunction("Entering Covid_Quarantined");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidquaranyes")));
                            start(); methodnamefiningfunction("Entering Covid_Quarantined");
                            driver.FindElement(By.Id("radiocovidquaranyes")).Click();
                            End();

                            scroll("halfdown");

                            //Remark
                            start(); methodnamefiningfunction("Entering Covid_Quarantined Remark");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtcovidquaranYes")));
                            driver.FindElement(By.Id("edtcovidquaranYes")).Clear();
                            driver.FindElement(By.Id("edtcovidquaranYes")).SendKeys(Covid_Quarantined_details);
                            End();

                        }
                        else
                        {
                            //No
                            start(); methodnamefiningfunction("Entering Covid_Quarantined No");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidquaranno")));
                            driver.FindElement(By.Id("radiocovidquaranno")).Click();
                            End();
                            scroll("down");
                        }

                        //Covid_Test
                        if (Covid_Test == "Yes")
                        {
                            //Yes
                            start(); methodnamefiningfunction("Entering Covid_Test");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidtestyes")));
                            driver.FindElement(By.Id("radiocovidtestyes")).Click();
                            End();

                            //Remark
                            start(); methodnamefiningfunction("Entering Covid_Test Remark");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtcovidtestYes")));
                            driver.FindElement(By.Id("edtcovidtestYes")).Clear();
                            driver.FindElement(By.Id("edtcovidtestYes")).SendKeys(Covid_Test_details);
                            End();
                            scroll("halfdown");
                        }
                        else
                        {
                            //No
                            start(); methodnamefiningfunction("Entering Covid_Test No");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidtestno")));
                            driver.FindElement(By.Id("radiocovidtestno")).Click();
                            End();
                        }
                        scroll("down");

                        //Covid_Symptoms

                        if (Covid_Symptoms == "Yes")
                        {
                            //Yes
                            start(); methodnamefiningfunction("Entering Covid_Symptoms");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidsymptomsyes")));
                            driver.FindElement(By.Id("radiocovidsymptomsyes")).Click();
                            End();

                            //Remark
                            start(); methodnamefiningfunction("Entering Covid_Symptoms Remark");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtcovidsymptomsYes")));
                            driver.FindElement(By.Id("edtcovidsymptomsYes")).Clear();
                            driver.FindElement(By.Id("edtcovidsymptomsYes")).SendKeys(Covid_Symptoms_details);
                            End();
                            scroll("halfdown");
                        }
                        else
                        {
                            //No
                            start(); methodnamefiningfunction("Entering Covid_Symptoms No");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidsymptomsno")));
                            driver.FindElement(By.Id("radiocovidsymptomsno")).Click();
                            End();
                        }
                        scroll("halfdown");

                        //
                        if (Covid_Travelhistory == "Yes")
                        {
                            //Yes
                            start(); methodnamefiningfunction("Entering Covid_Travelhistory");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidtravelyes")));
                            driver.FindElement(By.Id("radiocovidtravelyes")).Click();
                            End();

                            //Remark
                            start(); methodnamefiningfunction("Entering Covid_Travelhistory Remark");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtcovidtravelYes")));
                            driver.FindElement(By.Id("edtcovidtravelYes")).Clear();
                            driver.FindElement(By.Id("edtcovidtravelYes")).SendKeys(Covid_Travelhistory_details);
                            End();
                            scroll("halfdown");
                        }
                        else
                        {
                            //No
                            start(); methodnamefiningfunction("Entering Covid_Travelhistory No");
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiocovidtravelno")));
                            driver.FindElement(By.Id("radiocovidtravelno")).Click();
                            End();
                        }
                    }
                    catch { }

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

                    if (Any_criminal_case_in_court == "Yes")
                    {
                        start(); methodnamefiningfunction("Clicking Insurance Any_form_of_racing_etc");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioconvictcaseyes")));
                        driver.FindElement(By.Id("radioconvictcaseyes")).Click();
                        End();

                        //Any_form_of_racing_etc-Provide details
                        start(); methodnamefiningfunction("Clicking Any_form_of_racing_etc_provide_details");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtconvictcaseYes")));
                        driver.FindElement(By.Id("edtconvictcaseYes")).SendKeys(Any_criminal_case_in_court_provide_details);
                        End();
                    }
                    else
                    {
                        start(); methodnamefiningfunction("Clicking Any_form_of_racing_etc");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioconvictcaseno")));
                        driver.FindElement(By.Id("radioconvictcaseno")).Click();
                        End();
                    }

                    //existing life assurance policy rejected
                    if (Insurance_Policy_Rejected == "Yes")
                    {
                        start(); methodnamefiningfunction("Clicking Insurance rejected");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rGRejectYes")));
                        driver.FindElement(By.Id("rGRejectYes")).Click();
                        End();

                        //adding rejected deatils reason
                        start(); methodnamefiningfunction("Entering Insurance rejected Reason");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("tvPrevInsYes21")));
                        driver.FindElement(By.Id("tvPrevInsYes21")).SendKeys(Insurance_Policy_Rejected_Reason);

                        scroll("halfdown");

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("addButt")));
                        driver.FindElement(By.Id("addButt")).Click();
                        End();

                        //adding rejected deatils policy number
                        start(); methodnamefiningfunction("Entering Insurance rejected Policy Number");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtPolicyNo")));
                        driver.FindElement(By.Id("edtPolicyNo")).SendKeys(Insurance_Policy_Rejected_PolicyNumber);
                        End();

                        //adding rejected deatils company name
                        start(); methodnamefiningfunction("Entering Insurance rejected company name");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtCompanyNmeSpin")));
                        driver.FindElement(By.Id("edtCompanyNmeSpin")).Click();
                        Thread.Sleep(500);
                        try
                        {
                            driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                                        + "new UiSelector().text(\"" + Insurance_Policy_Rejected_CompanyName + "\"));").Click();
                        }
                        catch
                        {
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Insurance_Policy_Rejected_CompanyName + "']")));
                            driver.FindElement(By.XPath("//*[@text='" + Insurance_Policy_Rejected_CompanyName + "']")).Click();
                        }
                        End();


                        //adding rejected deatils sum assured
                        start(); methodnamefiningfunction("Entering Insurance rejected Sum Assured");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsum")));
                        driver.FindElement(By.Id("edtsum")).SendKeys(Insurance_Policy_Rejected_SumAssured);
                        End();

                        //save
                        start(); methodnamefiningfunction("Clicking Save");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnok")));
                        driver.FindElement(By.Id("btnok")).Click();
                        End();
                    }
                    else if (Insurance_Policy_Rejected == "No")
                    {
                        start(); methodnamefiningfunction("Clicking Insurance rejected");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rGRejectNo")));
                        driver.FindElement(By.Id("rGRejectNo")).Click();
                        End();
                    }

                    new TouchAction(driver).Press(506, 1486).MoveTo(533, 743).Release().Perform();

                    //life insurance policy already applied
                    if (Insurance_Already_Applied == "Yes")
                    {
                        start(); methodnamefiningfunction("Clicking Insurance already Applied");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("prevPolicyApplyYes")));
                        driver.FindElement(By.Id("prevPolicyApplyYes")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("addButtApply")));
                        driver.FindElement(By.Id("addButtApply")).Click();
                        End();

                        //adding already applied policy number
                        start(); methodnamefiningfunction("Entering Already Applied Insurance  Policy Number");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtPolicyNo")));
                        driver.FindElement(By.Id("edtPolicyNo")).SendKeys(Insurance_Already_Applied_policyNumber);
                        End();

                        //adding already applied company name
                        start(); methodnamefiningfunction("Entering Already Applied Insurance Company Name");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtCompanyNmeSpin")));
                        driver.FindElement(By.Id("edtCompanyNmeSpin")).Click();
                        Thread.Sleep(500);

                        try
                        {
                            driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                    + "new UiSelector().text(\"" + Insurance_Already_Applied_CompanyName + "\"));").Click();
                        }
                        catch
                        {
                            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Insurance_Already_Applied_CompanyName + "']")));
                            driver.FindElement(By.XPath("//*[@text='" + Insurance_Already_Applied_CompanyName + "']")).Click();
                        }

                        End();

                        //adding already applied Sum Assured
                        start(); methodnamefiningfunction("Entering Already Applied Insurance Sum Assured");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsum")));
                        driver.FindElement(By.Id("edtsum")).SendKeys(Insurance_Already_Applied_SumAssured);
                        End();

                        //policy issue date
                        start(); methodnamefiningfunction("Clicking Already applied policy Issue date");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalender")));
                        driver.FindElement(By.Id("dateCalender")).Click();
                        Policy_Issued_date(Policy_Issued_Date);
                        End();

                        //policy status
                        start(); methodnamefiningfunction("Entering Already Applied Insurance Policy Status");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtPlyStatus")));
                        driver.FindElement(By.Id("edtPlyStatus")).Click();

                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Insurance_Already_Applied_PolicyStatus + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Insurance_Already_Applied_PolicyStatus + "']")).Click();
                        End();

                        //Save
                        start(); methodnamefiningfunction("Clicking Save");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnok")));
                        driver.FindElement(By.Id("btnok")).Click();
                        End();
                    }
                    else if (Insurance_Already_Applied == "No")
                    {
                        start(); methodnamefiningfunction("Clicking Insurance already Applied");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("prevPolicyApplyNo")));
                        driver.FindElement(By.Id("prevPolicyApplyNo")).Click();
                        End();
                    }
                    try { scroll("down"); } catch { new TouchAction(driver).Press(506, 1486).MoveTo(533, 743).Release().Perform(); }

                    //string[] family_members = Name_of_Family_Member.Split(',');

                    //int[] intarr = new int[family_members.Length];

                    //for (int i = 0; i < intarr.Length; i++)
                    //{
                    //    //adding family Details
                    //    start(); methodnamefiningfunction("Clicking famil deatils");
                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("addFamMem")));
                    //    driver.FindElement(By.Id("addFamMem")).Click();
                    //    End();

                    //    //Name_of_Family_Member
                    //    start(); methodnamefiningfunction("Entering Name_of_Family_Member");
                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtNameofFamilyMem")));
                    //    driver.FindElement(By.Id("edtNameofFamilyMem")).SendKeys(family_members[i]);
                    //    End();

                    //    //select relationship
                    //    string[] Realtionship = Family_Details_Relationship.Split(',');

                    //    start(); methodnamefiningfunction("Selecting Relationship");
                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("familyRelations")));
                    //    driver.FindElement(By.Id("familyRelations")).Click();

                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Realtionship[i] + "']")));
                    //    driver.FindElement(By.XPath("//*[@text='" + Realtionship[i] + "']")).Click();
                    //    End();

                    //    //Entering Age 
                    //    string[] age = Family_Details_Age.Split(',');

                    //    start(); methodnamefiningfunction("Entering Age");
                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAge")));
                    //    driver.FindElement(By.Id("edtAge")).SendKeys(age[i]);
                    //    End();

                    //    string[] status = Family_Details_Status.Split(',');

                    //    //status
                    //    start(); methodnamefiningfunction("Selecting status");
                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("familyStatus")));
                    //    driver.FindElement(By.Id("familyStatus")).Click();

                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + status[i] + "']")));
                    //    driver.FindElement(By.XPath("//*[@text='" + status[i] + "']")).Click();
                    //    End();

                    //    if (status[i] == "Alive")
                    //    {
                    //        //health status
                    //        string[] health_status = Family_Details_Health_Status.Split(',');

                    //        start(); methodnamefiningfunction("Entering Health Status");
                    //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("healthStatus")));
                    //        driver.FindElement(By.Id("healthStatus")).Click();

                    //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + health_status[i] + "']")));
                    //        driver.FindElement(By.XPath("//*[@text='" + health_status[i] + "']")).Click();

                    //        if (health_status[i] == "Adverse")
                    //        {
                    //            try
                    //            {
                    //                string[] health_status1 = Adverse_Reason.Split(',');
                    //                Wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtstatus")));
                    //                driver.FindElement(By.Id("edtstatus")).SendKeys(health_status1[i]);
                    //            }
                    //            catch { }
                    //            try
                    //            {
                    //                Wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtstatus")));
                    //                driver.FindElement(By.Id("edtstatus")).SendKeys(Adverse_Reason);
                    //            }
                    //            catch { }
                    //        }
                    //        End();
                    //    }
                    //    else if (status[i] == "Death")
                    //    {
                    //        start(); methodnamefiningfunction("Entering Health Status");
                    //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderdeath")));
                    //        driver.FindElement(By.Id("dateCalenderdeath")).Click();

                    //        Deathdate(Death_Date);

                    //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtDeathReason")));
                    //        driver.FindElement(By.Id("edtDeathReason")).SendKeys(Death_Reason);
                    //        End();
                    //    }

                    //    //ok
                    //    start(); methodnamefiningfunction("Clicking ok");
                    //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnok")));
                    //    driver.FindElement(By.Id("btnok")).Click();
                    //    End();
                    //}

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
            }
        }
    


        