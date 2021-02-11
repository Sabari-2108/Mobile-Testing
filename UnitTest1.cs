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
    //---------------------------Prepared & Modified by Balaji.S-----------------------//

    [TestClass]
    public class UnitTest1
    {
        public static AndroidDriver<AndroidElement> driver;
        public static WebDriverWait Wait, wait, wait1, wait2, Wait2, waity;

        public static string Proposal_Type, LA_Title, LA_First_Name, LA_Middle_Name, Nature_of_Duties, LA_LastName, LA_Gender, LA_Marital_Status, Spouse_Name, Spouse_Age, LA_Mobile_No, Whatsapp_Contact, Father_Name, LA_Aadhar_Number, LA_PAN_Number, Proposer_DOB, Annual_Income, Nationality, NRI_Country, Resident_Of_Any_country_outside, NRI_Country_Address, Tax_Resident_Of_Any_country_outside, TIN_Issues_country, TIN, Holding_Telephone_Outside_India, Holding_Telephone_Outside_Mobile_Number, Holding_Telephone_Outside_Landline_Number, Transfer_Fund_Jurisdiction_outside_India, Transfer_Fund_Jurisdiction_outside_India_Detail, Signator_Authority_juridiction_outside_India, Signator_Authority_juridiction_outside_India_Name, Signator_Authority_juridiction_outside_India_Address, Hold_Mail_Jurisdiction_outside_India, Hold_Mail_Jurisdiction_outside_India_Details, PEP, Preferred_Language, EIA, FATCA, Passport_number, Passport_Expiry_Date, Country_of_Current_Residence, Purpose_of_Stay_in_Abroad, Date_of_Coming_to_India, Proposed_Date_of_Leaving_India, NRI_Bank_Name, Account_Number, Source_from_which_future_Premiums_are_Paid, NRI_Resident_Country, EIA_Number, Insurance_Repository, Plan_Name, Maturity_Benefit, Death_Benefit, Maturity_PayoutMode, Death_PayoutMode, Age_Proof, Policy_Term, Premium_Term, Premium_Mode, Sum_Assured, Family_Income, Accident_Benefit, Shriram_Critical, Shriram_Extra_Insurance, Policy_Sourced_by, Source_Code, Smoke_Type, Alcohol_Type, Percentage_of_Disability, Passport_Expire_Date, Policy_Issued_Date, date_of_coming, Passport_expiry, Nominee_DOB, LA_Date, Insurance_Policy_Rejected, Insurance_Policy_Rejected_Reason, Insurance_Policy_Rejected_PolicyNumber, Insurance_Policy_Rejected_CompanyName, Insurance_Policy_Rejected_SumAssured, Insurance_Already_Applied, Insurance_Already_Applied_policyNumber, Insurance_Already_Applied_CompanyName, Insurance_Already_Applied_SumAssured, Insurance_Already_Applied_PolicyStatus, Name_of_Family_Member, Family_Details_Relationship, Family_Details_Age, Family_Details_Status, Family_Details_Health_Status, Adverse_Reason, Death_Reason, Death_Date, Driving_License_Expire_Date;

        public static string Weight, Height_FT, Height_Inches, Smoke, Smoke_Quantity, Alcohol, Alcohol_Quantity, Defect_or_Deformity, Deformity_Type, Deformity_Reason, Walk_with_aid, Limbs_Affected, Rejected_for_any_insurance, Remarks_for_Rejected_Life_insurance, Currently_Pregnant, Remarks_for_Pregnant, Delivered_a_Baby, Date_for_Delivered_a_Baby, Miscarriages, Date_for_Miscarriages, Covid_Quarantined, Covid_Quarantined_details, Covid_Test, Covid_Test_details, Covid_Symptoms, Covid_Symptoms_details, Covid_Travelhistory, Covid_Travelhistory_details, Door_No_Permanent_Address, Street_Permanent_Address, Pincode_Permanent_Address, Area_Permanent_Address, Copy_Communication_Address_as_Permanent_Address, Door_No_Communication_Address, Street_Communication_Address, Pincode_Communication_Address, Area_Communication_Address, Educational_Qualification, Occupation, Occupation_Sub_Category, Driver_Type, Others, Driver_kilometer, Driver_limits, Driver_public, Driver_National, Self_Business, Type_of_Business, Rank, Current_Work_Location, Current_Nature, Special_Assignment, Job, Job_If_Yes, carries_Gun, Rank_Navy, Exact_Nature_Navy, Rank_Air, Duty_Air, Aircraft_Type, Special_Asssignment_Air, Cargo_Marine, Job_Marine, Vessel_Marine, Offshore_Oil, Offshore_Oil_Yes, Travel_Oil, Time_Year, Travel_Duration, Mine_Type, Involved_Mining, Underground_Duty, Underground_WorkHr, Husband_Occupation, Husband_Annual_Income, Husband_Insurance_Detail_Amount, Email, Nominee_Title, First_Name_of_Nominee, Middle_Name_of_Nominee, Last_Name_of_Nominee, Nominee_Gender, Relationship_to_Assured, AppointeeFName, AppointeeMName, AppointeeLName, Appointee_Relationship, Payout_Options, Payment, Customer_Alternate_No, Confirm_TPIN, Instrument_Type, Payout_Option, Payout_Mode, Genius_Maturity_Benefit, Genius_Death_Benefit, Educational_Benefit, DD_Cheque_No, Bank_Name, Bank_Branch, Alternate_Mobile_Number, Alternate_Email_ID, Latest_Photograph_of_Life_Assured, Age_Proof_Upload, ID_Proof_Upload, ID_Proof, Selfie_Photo_graph, Addres_Proof_Upload, Address_Proof, Income_Proof_Upload, Income_Proof, Life_Cover_Type, MaturityDeath_Benefit, Single_Premium, AssuredIncome_AnnualPremium, Objective_of_Insurance, Relationship, Reason_Self, Life_Type, Prop_Policy_Exist, Proposer_Title, Proposer_Firstname, Proposer_Middle_Name, Proposer_last_Name, Proposer_Mobile_Number, Proposer_PAN_Number, Proposer_Occupation, Proposer_Aadhaar_number, Proposer_relation, Proposer_Annual_Income, Proposer_Nationality, Proposer_Address_Same_As_Life_Assured, Proposer_DoorNo, Proposer_Street, Proposer_Pincode, Proposer_Area, Proposal_Photograph, Prop_ID_Proof_Upload, Prop_ID_Proof, Prop_Address_Proof_Upload, Prop_Address_Proof, Prop_Income_Proof_Upload, Prop_Income_Proof, Declaration_Photo_Copy, Passport_Proof, NACH_Document_Upload;

        public static string Category, Good_health_Actively_at_Work, Registration_Type, Any_Harmful_Drugs, Any_Harmful_Drugs_Provide_Details, Treated_For_Any_Illness, Treated_For_Any_Illness_Provide_Details, Good_health_Specify_Adversity_Noted, Children_Education, Children_Employment_Status, Children_Gender, Children_Martial_Status, Children_Age, Details_of_Children, Specify_Adversity_Noted, SickLeave_due_to_Noval_Coronavirus, Nature_of_Work_With_Covid, Diagnosed_with_Noval_Coronavirus, Sufficient_PPE, Name_of_Health_Authority, Name_and_Address_of_healthcare_facility, Exact_Nature, Medical_Specialty, Any_leave_from_your_service_on_medical_grounds, Any_leave_from_your_service_on_medical_grounds_provide_details, Any_accident_or_injury_that_required_any_medical_treatment, Any_accident_or_injury_that_required_any_medical_treatment_provide_details, Had_any_gynaecological_problems_requiring_treatment, Had_any_gynaecological_problems_requiring_treatment_provide_details, Ailments_relating_to_heart, Ailments_relating_to_heart_provide_details, Tested_positive_for_Hepatitis_B, Tested_positive_for_Hepatitis_B_provide_details, Other_Respiratory_disorders, Other_Respiratory_disorders_provide_details, Diabetes_and_Low_BP, Diabetes_and_Low_BP_provide_details, Musculoskeletal_disorders, Musculoskeletal_disorders_provide_details, Ailment_that_required_treatment, Ailment_that_required_treatment_provide_details, Any_disorder_of_Eye, Any_disorder_of_Eye_provide_details, Any_form_of_racing_etc, Any_form_of_racing_etc_provide_details, Any_criminal_case_in_court, Any_criminal_case_in_court_provide_details;

        public class GlobalVariables
        {
            public static int countOfTestMethods = 0, tot = countOfTestMethods, passed = 0, faild = 0, totalsteps, r = 0;
            public static dynamicemailtemplate dct = new ClassLibrary7.reports.dynamicemailtemplate();
            public static string Asmbname, prjpath, name, methodname, Filename, link, TC = "0", PC = "0", FC = "0";
        }

        public static string f1 = DateTime.Now.ToString("MM-dd_HHmmss");
        public static int count, i = 0;
        string Scenario = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
        string outPutDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string totalcalc = (System.IO.Directory.GetParent(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)).Parent.Parent.FullName + ("\\" + (System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "\\UnitTest1.cs")));
        string url;
        public int g;
        string prjname, nagvpath;
        string appname = "SLIC";

        public void methodnamefiningfunction(string mname)
        {
            GlobalVariables.methodname = mname;
            i = i + 1;
        }
        public void start()
        {
            GlobalVariables.dct.starttimefunction();
            GlobalVariables.dct.CountNumberOfTestMethods(ref GlobalVariables.countOfTestMethods, ref GlobalVariables.prjpath);
        }
        public void End()
        {
            GlobalVariables.dct.callingcommanmethod(GlobalVariables.name, GlobalVariables.methodname);
            GlobalVariables.dct.endtimefunction(ref GlobalVariables.passed, ref GlobalVariables.faild, ref GlobalVariables.countOfTestMethods);
            GlobalVariables.dct.excelclosefunction();
        }

        public void Capture()
        {
            var screen = ((ITakesScreenshot)driver).GetScreenshot();
            GlobalVariables.link = "\\\\192.169.1.55\\Automation reports\\SLIC_Mobile\\SLIC_SO_Proposal\\SUCCESS_" + g + "_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png";
            screen.SaveAsFile(GlobalVariables.link);
        }
        public void scroll(string Direction)
        {
            var size = driver.Manage().Window.Size;

            //full bottom to top swipe(down)
            int startyyyy = (int)(size.Height * 0.65);
            int endyyyy = (int)(size.Height * 0.20);
            int startxxxx = size.Width / 2;

            //half down
            int startx12 = size.Width / 2;
            int starty112 = (int)(size.Height * 0.50);
            int endy112 = (int)(size.Height * 0.20);

            ////Up
            int startxup = size.Width / 2;
            int startyup = (int)(size.Height * 0.30);
            int endyup = (int)(size.Height * 0.70);

            if (Direction == "down")
            {
                Thread.Sleep(1000);
                new TouchAction(driver).Press(startxxxx, startyyyy).Wait(700).MoveTo(startxxxx, endyyyy).Release().Perform();

            }
            else if (Direction == "halfdown")
            {
                Thread.Sleep(1000);
                new TouchAction(driver).Press(startx12, starty112).Wait(700).MoveTo(startx12, endy112).Release().Perform();
            }
            else if (Direction == "up")
            {
                Thread.Sleep(1000);
                new TouchAction(driver).Press(startxup, startyup).Wait(700).MoveTo(startxup, endyup).Release().Perform();
            }
        }
        public void DOB(string LA_Date)
        {
            string date = LA_Date.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);
            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }

        public void DOB1(string Proposer_DOB)
        {
            string date = Proposer_DOB.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyears = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='2002']")));
            driver.FindElement(By.XPath("//*[@text='2002']")).Click();
            driver.FindElement(By.XPath("//*[@text='2002']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);


            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }

        public void dateofleavingindia(string Proposed_Date_of_Leaving_India)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            string date = Proposed_Date_of_Leaving_India.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);
            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void dateofcoming(string date_of_coming)
        {
            string date = date_of_coming.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);
            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void Passportexpiry(string Passport_expiry)
        {
            string date = Passport_expiry.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);
            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void Details_of_Children_Age(string Children_Age)
        {
            string date = Children_Age.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='2002']")));
            driver.FindElement(By.XPath("//*[@text='2002']")).Click();
            driver.FindElement(By.XPath("//*[@text='2002']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void Nomine_DOB(string Nominee_DOB)
        {
            string date = Nominee_DOB.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void DOB_Passport(string Passport_Expire_Date)
        {
            string date = Passport_Expire_Date.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);
            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void DOB_License(string Driving_License_Expire_Date)
        {
            string date = Driving_License_Expire_Date.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }
        public void Deathdate(string Death_Date)
        {
            string date = Death_Date.Replace("/", "");

            string day = date.Substring(0, 2);

            string Month = date.Substring(2, 2);
            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);
            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }

        public void Policy_Issued_date(string Policy_Issued_Date)
        {
            string date = Policy_Issued_Date.Replace("/", "");
            string day = date.Substring(0, 2);
            string Month = date.Substring(2, 2);

            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }

        public void Miscarriage_Date(string Date_for_Miscarriages)
        {
            string date = Date_for_Miscarriages.Replace("/", "");
            string day = date.Substring(0, 2);
            string Month = date.Substring(2, 2);

            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }

        public void Delivered_Baby_Date(string Date_for_Delivered_a_Baby)
        {
            string date = Date_for_Delivered_a_Baby.Replace("/", "");
            string day = date.Substring(0, 2);
            string Month = date.Substring(2, 2);

            int mon = Convert.ToInt16(Month);

            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mon);

            string year = date.Substring(date.Length - 4, 4);

            string currentmonth = DateTime.Now.ToString("MMMM").Substring(0, 3);
            string currentyear = DateTime.Now.Year.ToString();
            string currentday = DateTime.Now.ToString("dd").Substring(0, 2);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentyear + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentyear + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(year);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentmonth + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentmonth + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(monthName);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + currentday + "']")));
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Click();
            driver.FindElement(By.XPath("//*[@text='" + currentday + "']")).Clear();
            driver.FindElement(By.XPath("//android.widget.EditText[@text='']")).SendKeys(day);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
        }

        [NUnit.Framework.Test]
        [TestMethod]
        public void TestMethod1()
        {
            string project = "SLIC";
            string Script = "SLIC_Astra_Proposal";
            string[] sheets = { "Sheet1", "Sheet2" };
            string sheetName = "";
            string tablename = "";

            //-------------------------------------DataBase-----------------------------------------------------------//

            int i = 0, j = 1; string a1 = "a", a2 = "b";
            string Temp = "", Temp2 = "";
            var tempsheet = "";
            foreach (var sheet in sheets)
            {
                if (i == 0)
                {
                    Temp = string.Concat(a1, j.ToString());
                    Temp2 = string.Concat(a2, j.ToString());
                    sheetName = sheet;
                    tempsheet = project + "." + Script + "_" + sheet + " as " + Temp;
                    i++;
                }
                else
                {
                    tempsheet = tempsheet + " inner join " + project + "." + Script + "_" + sheet + " as " + Temp2 + " On " + Temp + ".Primary_ID=" + Temp2 + ".Primary_ID";
                    j++;
                    Temp = Temp2;
                    Temp2 = string.Concat(a2, j.ToString());
                }
            }
            tablename = tempsheet;
            SqlCommand command = null;
            DataSet dtset = new DataSet();
            SqlDataAdapter sda = null;
            int Count = 0, Pk_Id = 0, iteration = 0; int r1 = 0;
            DataTable Table_Data = new DataTable();
            SqlConnection con = new SqlConnection("Data Source=192.169.1.181\\sql2017;Initial Catalog=Automation;;User ID=sa;Password=welcome3#");
            try
            {
                i = 0; j = 1; a1 = "a"; a2 = "b";
                Temp = ""; Temp2 = "";
                foreach (var sheet in sheets)
                {
                    if (i == 0)
                    {
                        Temp = string.Concat(a1, j.ToString());
                        Temp2 = string.Concat(a2, j.ToString());
                        sheetName = sheet;
                        tempsheet = Script + "_" + sheet + " as " + Temp;
                        i++;
                    }
                    else
                    {
                        tempsheet = tempsheet + " inner join " + Script + "_" + sheet + " as " + Temp2 + " On " + Temp + ".Primary_ID=" + Temp2 + ".Primary_ID";
                        j++;
                        Temp = Temp2;
                        Temp2 = string.Concat(a2, j.ToString());
                    }
                }
                command = new SqlCommand("select  a1.Primary_ID as row,* from " + tempsheet, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dtset);
                command = new SqlCommand("select COUNT_BIG(*) from " + tempsheet, con);
                Count = Convert.ToInt32(command.ExecuteScalar());
                command = new SqlCommand("select top(1) URL_Address from " + Script + "_" + sheetName, con);
                url = command.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception) { }

            if (dtset.Tables.Count > 0)
            {
                tablename = Script + "_" + sheetName;
                Table_Data = dtset.Tables[0];
                r1 = Count;
                foreach (var sheet in sheets)
                {
                    command = new SqlCommand("Drop table " + Script + "_" + sheet, con);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }
            }
            else
            {
                command = new SqlCommand("[dbo].[ProjectLoad]", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@mode", "Get_Flow_TableRecords");
                command.Parameters.AddWithValue("@script", Script);
                command.Parameters.AddWithValue("@project", project);
                command.Parameters.AddWithValue("@tablename", tablename);
                sda = new SqlDataAdapter(command);
                sda.Fill(dtset);
                Count = Convert.ToInt16(dtset.Tables[0].Rows[0][0]);
                Pk_Id = Convert.ToInt16(dtset.Tables[1].Rows[0][0]);
                iteration = Convert.ToInt16(dtset.Tables[1].Rows[0][1]);
                string url = dtset.Tables[1].Rows[0][2].ToString();    //newly added
                Table_Data = dtset.Tables[2];
                r1 = iteration != 0 ? Count < iteration ? Count : iteration : Count;
            }
            foreach (DataRow reader in Table_Data.Rows)
            {
                int temp = Convert.ToInt32(reader["Primary_ID"]);
                string g1 = reader["row"].ToString();
                g = Convert.ToInt16(g1);
                GlobalVariables.r = r1 + 1;
                GlobalVariables.totalsteps = 105;
                prjname = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                GlobalVariables.dct.starttime_method(); // to obtain the start time for one iteration

                Proposal_Type = reader["Proposal_Type"].ToString();
                LA_Title = reader["LA_Title"].ToString();
                LA_First_Name = reader["LA_First_Name"].ToString();
                LA_Middle_Name = reader["LA_Middle_Name"].ToString();
                LA_LastName = reader["LA_LastName"].ToString();
                LA_Gender = reader["LA_Gender"].ToString();
                LA_Marital_Status = reader["LA_Marital_Status"].ToString();
                Spouse_Name = reader["Spouse Name"].ToString();
                Spouse_Age = reader["Spouse Age"].ToString();
                LA_Mobile_No = reader["LA_Mobile_No"].ToString();
                Whatsapp_Contact = reader["Whatsapp_Contact"].ToString();
                Father_Name = reader["Father_Name"].ToString();
                LA_Aadhar_Number = reader["LA_Aadhar_Number"].ToString();
                LA_PAN_Number = reader["LA_PAN_Number"].ToString();
                string Proposer_DOB = reader["Proposer_DOB"].ToString();
                Annual_Income = reader["Annual_Income"].ToString();
                Nature_of_Duties = reader["Nature_of_Duties"].ToString();
                Nationality = reader["Nationality"].ToString();
                NRI_Country = reader["NRI_Country"].ToString();
                Resident_Of_Any_country_outside = reader["Resident_Of_Any_country_outside"].ToString();
                NRI_Country_Address = reader["NRI_Country_Address"].ToString();
                Tax_Resident_Of_Any_country_outside = reader["Tax_Resident_Of_Any_country_outside"].ToString();
                TIN_Issues_country = reader["TIN_Issues_country"].ToString();
                TIN = reader["TIN"].ToString();
                Holding_Telephone_Outside_India = reader["Holding_Telephone_Outside_India"].ToString();
                Holding_Telephone_Outside_Mobile_Number = reader["Holding_Telephone_Outside_Mobile_Number"].ToString();
                Holding_Telephone_Outside_Landline_Number = reader["Holding_Telephone_Outside_Landline_Number"].ToString();
                Transfer_Fund_Jurisdiction_outside_India = reader["Transfer_Fund_Jurisdiction_outside_India"].ToString();
                Transfer_Fund_Jurisdiction_outside_India_Detail = reader["Transfer_Fund_Jurisdiction_outside_India_Detail"].ToString();
                Signator_Authority_juridiction_outside_India = reader["Signator_Authority_juridiction_outside_India"].ToString();
                Signator_Authority_juridiction_outside_India_Name = reader["Signator_Authority_juridiction_outside_India_Name"].ToString();
                Signator_Authority_juridiction_outside_India_Address = reader["Signator_Authority_juridiction_outside_India_Address"].ToString();
                Hold_Mail_Jurisdiction_outside_India = reader["Hold_Mail_Jurisdiction_outside_India"].ToString();
                Hold_Mail_Jurisdiction_outside_India_Details = reader["Hold_Mail_Jurisdiction_outside_India_Details"].ToString();
                PEP = reader["PEP"].ToString();
                Preferred_Language = reader["Preferred_Language"].ToString();
                EIA = reader["EIA"].ToString();
                FATCA = reader["FATCA"].ToString();
                Passport_number = reader["Passport_number"].ToString();
                Passport_Expiry_Date = reader["Passport Expiry Date"].ToString();
                Country_of_Current_Residence = reader["Country of Current Residence"].ToString();
                Purpose_of_Stay_in_Abroad = reader["Purpose of Stay in Abroad"].ToString();
                Date_of_Coming_to_India = reader["Date of Coming to India"].ToString();
                Proposed_Date_of_Leaving_India = reader["Proposed Date of Leaving India"].ToString();
                NRI_Bank_Name = reader["NRI_Bank_Name"].ToString();
                Account_Number = reader["Account Number"].ToString();
                Source_from_which_future_Premiums_are_Paid = reader["Source from which future Premiums are Paid"].ToString();
                NRI_Resident_Country = reader["NRI_Resident_Country"].ToString();
                EIA_Number = reader["EIA_Number"].ToString();
                Insurance_Repository = reader["Insurance_Repository"].ToString();
                Plan_Name = reader["Plan_Name"].ToString();
                Maturity_Benefit = reader["Maturity Benefit"].ToString();
                Death_Benefit = reader["Death Benefit"].ToString();
                Maturity_PayoutMode = reader["Maturity Payout Mode"].ToString();
                Death_PayoutMode = reader["Death Payout Mode"].ToString();
                Age_Proof = reader["Age_Proof"].ToString();
                Policy_Term = reader["Policy_Term"].ToString();
                Premium_Term = reader["Premium_Term"].ToString();
                Premium_Mode = reader["Premium_Mode"].ToString();
                Sum_Assured = reader["Sum_Assured"].ToString();
                Family_Income = reader["Family Income Benefit Rider V02"].ToString();
                Accident_Benefit = reader["Accident Benefit Rider V02"].ToString();
                Shriram_Critical = reader["Shriram Critical Illness Cover Rider"].ToString();
                Shriram_Extra_Insurance = reader["Shriram Extra Insurance Cover Rider"].ToString();
                Policy_Sourced_by = reader["Policy_Sourced_by"].ToString();
                Source_Code = reader["Source_Code"].ToString();
                Smoke_Type = reader["Smoke_Type"].ToString();
                Alcohol_Type = reader["Alcohol_Type"].ToString();
                Percentage_of_Disability = reader["Percentage_of_Disability"].ToString();
                Passport_Expire_Date = reader["ID Proof Expire Date"].ToString();
                Policy_Issued_Date = reader["Policy_Issued_Date"].ToString();
                date_of_coming = reader["Date of Coming to India"].ToString();
                Passport_expiry = reader["Passport Expiry Date"].ToString();
                Nominee_DOB = reader["Nominee_DOB"].ToString();
                LA_Date = reader["LA_Date"].ToString();
                Insurance_Policy_Rejected = reader["Insurance_Policy_Rejected"].ToString();
                Insurance_Policy_Rejected_Reason = reader["Insurance_Policy_Rejected_Reason"].ToString();
                Insurance_Policy_Rejected_PolicyNumber = reader["Insurance_Policy_Rejected_PolicyNumber"].ToString();
                Insurance_Policy_Rejected_SumAssured = reader["Insurance_Policy_Rejected_SumAssured"].ToString();
                Insurance_Policy_Rejected_CompanyName = reader["Insurance_Policy_Rejected_CompanyName"].ToString();
                Insurance_Already_Applied = reader["Insurance_Already_Applied"].ToString();
                Insurance_Already_Applied_policyNumber = reader["Insurance_Already_Applied_policyNumber"].ToString();
                Insurance_Already_Applied_CompanyName = reader["Insurance_Already_Applied_CompanyName"].ToString();
                Insurance_Already_Applied_SumAssured = reader["Insurance_Already_Applied_SumAssured"].ToString();
                Insurance_Already_Applied_PolicyStatus = reader["Insurance_Already_Applied_PolicyStatus"].ToString();
                Name_of_Family_Member = reader["Name_of_Family_Member"].ToString();
                Family_Details_Relationship = reader["Family_Details_Relationship"].ToString();
                Family_Details_Age = reader["Family_Details_Age"].ToString();
                Family_Details_Status = reader["Family_Details_Status"].ToString();
                Family_Details_Health_Status = reader["Family_Details_Health_Status"].ToString();
                Adverse_Reason = reader["Adverse_Reason"].ToString();
                Death_Reason = reader["Death_Reason"].ToString();
                Death_Date = reader["Death_Date"].ToString();
                Driving_License_Expire_Date = reader["Address Proof Expire Date"].ToString();

                //------------------------------Medical Details--------------------------//
                Weight = reader["Weight"].ToString();
                Height_FT = reader["Height_FT"].ToString();
                Height_Inches = reader["Height_Inches"].ToString();
                Smoke = reader["Smoke"].ToString();
                Smoke_Quantity = reader["Smoke_Quantity"].ToString();
                Alcohol = reader["Alcohol"].ToString();
                Alcohol_Quantity = reader["Alcohol_Quantity"].ToString();
                Defect_or_Deformity = reader["Defect_or_Deformity"].ToString();
                Deformity_Type = reader["Deformity_Type"].ToString();      
                Deformity_Reason = reader["Deformity_Reason"].ToString();
                Walk_with_aid = reader["Walk_with_aid"].ToString();
                Limbs_Affected = reader["Limbs_Affected"].ToString();
                Rejected_for_any_insurance = reader["Rejected_for_any_insurance"].ToString();
                Remarks_for_Rejected_Life_insurance = reader["Remarks_for_Rejected_Life_insurance"].ToString();
                Currently_Pregnant = reader["Currently_Pregnant"].ToString();
                Remarks_for_Pregnant = reader["Remarks_for_Pregnant"].ToString();
                Delivered_a_Baby = reader["Delivered_a_Baby"].ToString();
                Date_for_Delivered_a_Baby = reader["Date_for_Delivered_a_Baby"].ToString();
                Miscarriages = reader["Miscarriages"].ToString();
                Date_for_Miscarriages = reader["Date_for_Miscarriages"].ToString();
                Covid_Quarantined = reader["Covid_Quarantined"].ToString();
                Covid_Quarantined_details = reader["Covid_Quarantined_details"].ToString();
                Covid_Test = reader["Covid_Test"].ToString();
                Covid_Test_details = reader["Covid_Test_details"].ToString();
                Covid_Symptoms = reader["Covid_Symptoms"].ToString();
                Covid_Symptoms_details = reader["Covid_Symptoms_details"].ToString();
                Covid_Travelhistory = reader["Covid_Travelhistory"].ToString();
                Covid_Travelhistory_details = reader["Covid_Travelhistory_details"].ToString();
                Any_Harmful_Drugs = reader["Any_Harmful_Drugs"].ToString();
                Any_Harmful_Drugs_Provide_Details = reader["Any_Harmful_Drugs_Provide_Details"].ToString();
                Treated_For_Any_Illness = reader["Treated_For_Any_Illness"].ToString();
                Treated_For_Any_Illness_Provide_Details = reader["Treated_For_Any_Illness_Provide_Details"].ToString();
                Any_leave_from_your_service_on_medical_grounds = reader["Any_leave_from_your_service_on_medical_grounds"].ToString();
                Any_leave_from_your_service_on_medical_grounds_provide_details = reader["Any_leave_from_your_service_on_medical_grounds_provide_details"].ToString();
                Any_accident_or_injury_that_required_any_medical_treatment = reader["Any_accident_or_injury_that_required_any_medical_treatment"].ToString();
                Any_accident_or_injury_that_required_any_medical_treatment_provide_details = reader["Any_accident_or_injury_that_required_any_medical_treatment_provide_details"].ToString();
                Had_any_gynaecological_problems_requiring_treatment = reader["Had_any_gynaecological_problems_requiring_treatment"].ToString();
                Had_any_gynaecological_problems_requiring_treatment_provide_details = reader["Had_any_gynaecological_problems_requiring_treatment_provide_details"].ToString();
                Ailments_relating_to_heart = reader["Ailments_relating_to_heart"].ToString();
                Ailments_relating_to_heart_provide_details = reader["Ailments_relating_to_heart_provide_details"].ToString();
                Tested_positive_for_Hepatitis_B = reader["Tested_positive_for_Hepatitis_B"].ToString();
                Tested_positive_for_Hepatitis_B_provide_details = reader["Tested_positive_for_Hepatitis_B_provide_details"].ToString();
                Other_Respiratory_disorders = reader["Other_Respiratory_disorders"].ToString();
                Other_Respiratory_disorders_provide_details = reader["Other_Respiratory_disorders_provide_details"].ToString();
                Diabetes_and_Low_BP = reader["Diabetes_and_Low_BP"].ToString();
                Diabetes_and_Low_BP_provide_details = reader["Diabetes_and_Low_BP_provide_details"].ToString();
                Musculoskeletal_disorders = reader["Musculoskeletal_disorders"].ToString();
                Musculoskeletal_disorders_provide_details = reader["Musculoskeletal_disorders_provide_details"].ToString();
                Ailment_that_required_treatment = reader["Ailment_that_required_treatment"].ToString();
                Ailment_that_required_treatment_provide_details = reader["Ailment_that_required_treatment_provide_details"].ToString();
                Any_disorder_of_Eye = reader["Any_disorder_of_Eye"].ToString();
                Any_disorder_of_Eye_provide_details = reader["Any_disorder_of_Eye_provide_details"].ToString();
                Any_form_of_racing_etc = reader["Any_form_of_racing_etc"].ToString();
                Any_form_of_racing_etc_provide_details = reader["Any_form_of_racing_etc_provide_details"].ToString();
                Any_criminal_case_in_court = reader["Any_criminal_case_in_court"].ToString();
                Any_criminal_case_in_court_provide_details = reader["Any_criminal_case_in_court_provide_details"].ToString();

                //----------------------------Permanent Address Details----------------------------//
                Door_No_Permanent_Address = reader["Perm_DoorNo"].ToString();
                Street_Permanent_Address = reader["Perm_Street"].ToString();
                Pincode_Permanent_Address = reader["Perm_Pincode"].ToString();
                Area_Permanent_Address = reader["Perm_Area"].ToString();
                Copy_Communication_Address_as_Permanent_Address = reader["Comm Adder Same as Permanenet Address"].ToString();
                Door_No_Communication_Address = reader["Comm_DooNo"].ToString();
                Street_Communication_Address = reader["Comm_Street"].ToString();
                Pincode_Communication_Address = reader["Comm_Pincode"].ToString();
                Area_Communication_Address = reader["Comm_Area"].ToString();
                Educational_Qualification = reader["Education"].ToString();
                Occupation = reader["Occupation"].ToString();
                Occupation_Sub_Category = reader["OccupationCat"].ToString();
                Driver_Type = reader["Driver_Type"].ToString();
                Others = reader["Others"].ToString();
                Driver_kilometer = reader["Driver_kilometer"].ToString();
                Driver_limits = reader["Driver_limits"].ToString();
                Driver_public = reader["Driver_public Carriers"].ToString();
                Driver_National = reader["Driver_National Permit"].ToString();
                Self_Business = reader["Self_Business"].ToString();
                Type_of_Business = reader["Type_of_Business"].ToString();
                Rank = reader["Rank"].ToString();
                Current_Work_Location = reader["Current_Work_Location"].ToString();
                Current_Nature = reader["Current_Nature"].ToString();
                Special_Assignment = reader["Special_Assignment"].ToString();
                Job = reader["Job"].ToString();
                Job_If_Yes = reader["Job_If_Yes"].ToString();
                carries_Gun = reader["carries_Gun"].ToString();
                Rank_Navy = reader["Rank_Navy"].ToString();
                Exact_Nature_Navy = reader["Exact_Nature_Navy"].ToString();
                Rank_Air = reader["Rank_Air"].ToString();
                Duty_Air = reader["Duty_Air"].ToString();
                Aircraft_Type = reader["Aircraft_Type"].ToString();
                Special_Asssignment_Air = reader["Special_Asssignment_Air"].ToString();
                Cargo_Marine = reader["Cargo_Marine"].ToString();
                Job_Marine = reader["Job_Marine"].ToString();
                Vessel_Marine = reader["Vessel_Marine"].ToString();
                Offshore_Oil = reader["Offshore_Oil"].ToString();
                Offshore_Oil_Yes = reader["Offshore_Oil_Yes"].ToString();
                Travel_Oil = reader["Travel_Oil"].ToString();
                Time_Year = reader["Time_Year"].ToString();
                Travel_Duration = reader["Travel_Duration"].ToString();
                Mine_Type = reader["Mine_Type"].ToString();
                Involved_Mining = reader["Involved_Mining"].ToString();
                Underground_Duty = reader["Underground_Duty"].ToString();
                Underground_WorkHr = reader["Underground_WorkHr"].ToString();
                Husband_Occupation = reader["Husband_Occupation"].ToString();
                Husband_Annual_Income = reader["Husband_Annual_Income"].ToString();
                Husband_Insurance_Detail_Amount = reader["Husband_Insurance_Detail_Amount"].ToString();
                Email = reader["Email"].ToString();

                //----------------------------Nominee details--------------------------//
                Nominee_Title = reader["Nominee_Title"].ToString();
                First_Name_of_Nominee = reader["Nominee_FirstName"].ToString();
                Middle_Name_of_Nominee = reader["Nominee_MiddleName"].ToString();
                Last_Name_of_Nominee = reader["Nominee_LastName"].ToString();
                Nominee_Gender = reader["Nominee_Gender"].ToString();
                Relationship_to_Assured = reader["Nominee_Relation"].ToString();
                AppointeeFName = reader["AppointeeFName"].ToString();
                AppointeeMName = reader["AppointeeMName"].ToString();
                AppointeeLName = reader["AppointeeLName"].ToString();
                Appointee_Relationship = reader["Appointee_Relationship"].ToString();
                Payout_Options = reader["Assured_Payout_Options"].ToString();
                Payment = reader["Payment"].ToString();
                Customer_Alternate_No = reader["Customer_Alternate_No"].ToString();
                Confirm_TPIN = reader["Confirm_TPIN"].ToString();
                Instrument_Type = reader["Instrument_Type"].ToString();
                Payout_Option = reader["Assured_Payout_Options"].ToString();
                Payout_Mode = reader["Assured_Payout_Mode"].ToString();
                Genius_Maturity_Benefit = reader["Genius_Maturity_Benefit"].ToString();
                Genius_Death_Benefit = reader["Genius_Death_Benefit"].ToString();
                Educational_Benefit = reader["Genius_Educational_Benefit"].ToString();
                DD_Cheque_No = reader["Cheque/DD_Number"].ToString();
                Bank_Name = reader["Bank_Name"].ToString();
                Bank_Branch = reader["Bank_Branch"].ToString();
                Alternate_Mobile_Number = reader["Alternate_Mobile_Number"].ToString();
                Alternate_Email_ID = reader["Alternate_Email_ID"].ToString();
                Latest_Photograph_of_Life_Assured = reader["Latest_Photograph_of_Life_Assured"].ToString();
                Age_Proof_Upload = reader["Age_Proof_Upload"].ToString();
                ID_Proof_Upload = reader["ID_Proof_Upload"].ToString();
                ID_Proof = reader["ID_Proof"].ToString();
                Selfie_Photo_graph = reader["Selfie_Photo_graph"].ToString();
                Addres_Proof_Upload = reader["Addres_Proof_Upload"].ToString();
                Address_Proof = reader["Address_Proof"].ToString();
                Income_Proof_Upload = reader["Income_Proof_Upload"].ToString();
                Income_Proof = reader["Income_Proof"].ToString();
                Life_Cover_Type = reader["Life_Cover_Type"].ToString();
                MaturityDeath_Benefit = reader["Maturity/Death_Benefit"].ToString();
                Single_Premium = reader["Single_Premium"].ToString();
                AssuredIncome_AnnualPremium = reader["AssuredIncome_AnnualPremium"].ToString();
                Objective_of_Insurance = reader["Objective_of_Insurance"].ToString();
                Relationship = reader["Relationship"].ToString();
                Reason_Self = reader["Reason-Self"].ToString();

                //|-------------------Other Life------------------|//
                Life_Type = reader["Life_Type"].ToString();
                Prop_Policy_Exist = reader["Prop/Policy no(If Existing Cust)"].ToString();
                Proposer_Title = reader["Proposer_Title"].ToString();
                Proposer_Firstname = reader["Proposer_Firstname"].ToString();
                Proposer_Middle_Name = reader["Proposer_Middle Name"].ToString();
                Proposer_last_Name = reader["Proposer_last Name"].ToString();
                Proposer_DOB = reader["Proposer_DOB"].ToString();
                Proposer_Mobile_Number = reader["Proposer_Mobile Number"].ToString();
                Proposer_PAN_Number = reader["Proposer_PAN_Number"].ToString();
                Proposer_Occupation = reader["Proposer_Occupation"].ToString();
                Proposer_Aadhaar_number = reader["Proposer_Aadhaar number"].ToString();
                Proposer_relation = reader["Proposer_relation"].ToString();
                Proposer_Annual_Income = reader["Proposer_Annual_Income"].ToString();
                Proposer_Nationality = reader["Proposer_Nationality"].ToString();
                Proposer_Address_Same_As_Life_Assured = reader["Proposer_Address_Same_As_Life_Assured"].ToString();
                Proposer_DoorNo = reader["Proposer_DoorNo"].ToString();
                Proposer_Street = reader["Proposer_Street"].ToString();
                Proposer_Pincode = reader["Proposer_Pincode"].ToString();
                Proposer_Area = reader["Proposer_Area"].ToString();
                Proposal_Photograph = reader["Proposal_Photograph"].ToString();
                Prop_ID_Proof_Upload = reader["Prop_ID_Proof_Upload"].ToString();
                Prop_ID_Proof = reader["Prop_ID_Proof"].ToString();
                Prop_Address_Proof_Upload = reader["Prop_Address_Proof_Upload"].ToString();
                Prop_Address_Proof = reader["Prop_Address_Proof"].ToString();
                Prop_Income_Proof_Upload = reader["Prop_Income_Proof_Upload"].ToString();
                Prop_Income_Proof = reader["Prop_Income_Proof"].ToString();
                Declaration_Photo_Copy = reader["Declaration_Photo_Copy"].ToString();
                Passport_Proof = reader["Passport_Proof"].ToString();
                NACH_Document_Upload = reader["NACH_Document_Upload"].ToString();

                Good_health_Actively_at_Work = reader["Good_health_Actively_at_Work"].ToString();
                Specify_Adversity_Noted = reader["Specify_Adversity_Noted"].ToString();
                SickLeave_due_to_Noval_Coronavirus = reader["SickLeave_due_to_Noval_Coronavirus"].ToString();
                Nature_of_Work_With_Covid = reader["Nature_of_Work_With_Covid"].ToString();
                Diagnosed_with_Noval_Coronavirus = reader["Diagnosed_with_Noval_Coronavirus"].ToString();
                Sufficient_PPE = reader["Sufficient_PPE"].ToString();
                Name_of_Health_Authority = reader["Name_of_Health_Authority"].ToString();
                Name_and_Address_of_healthcare_facility = reader["Name_and_Address_of_healthcare_facility"].ToString();
                Exact_Nature = reader["Exact_Nature"].ToString();
                Medical_Specialty = reader["Medical_Specialty"].ToString();
                Children_Education = reader["Children_Education"].ToString();
                Children_Employment_Status = reader["Children_Employment_Status"].ToString();
                Children_Martial_Status = reader["Children_Martial_Status"].ToString();
                Children_Gender = reader["Children_Gender"].ToString();
                Children_Age = reader["Children_Age"].ToString();
                Details_of_Children = reader["Details_of_Children"].ToString();
                Good_health_Specify_Adversity_Noted = reader["Good_health_Specify_Adversity_Noted"].ToString();
                Registration_Type = reader["Registration_Type"].ToString();
                Category = reader["Category"].ToString();
                string Sl_No = reader["SL. No"].ToString();
                string Expected_Status = reader["Expected Status"].ToString();
                string testcaseid = reader["Test Case ID"].ToString();
                string Testcase_Description = reader["Test Case Description"].ToString();

                if (g1 == "1")
                {
                    // Appium_Start();
                    var cap = new AppiumOptions();
                    cap.AddAdditionalCapability("deviceName", "Moto");
                    cap.AddAdditionalCapability("platformName", "Android");
                    cap.AddAdditionalCapability("platformVersion", "8.1");
                    cap.AddAdditionalCapability("udid", "ZY2243C3JX");
                    cap.AddAdditionalCapability("automationName", "uiautomator2");
                    cap.AddAdditionalCapability("fullReset", true);
                    cap.AddAdditionalCapability("unicodeKeyboard", true);
                    cap.AddAdditionalCapability("autoGrantPermissions", true);
                    cap.AddAdditionalCapability("app", @"\\192.169.1.55\Automation reports\Mobile_Backup\MobileAPK\APK\SLIC_Astra_APK\250121\Astra.apk");
                    cap.AddAdditionalCapability("skipDeviceInitialization", true);
                    cap.AddAdditionalCapability("skipServerInstallation", true);
                    cap.AddAdditionalCapability("ignoreUnimportantViews", true);
                    cap.AddAdditionalCapability("appWaitPackage", "com.astra.slic");
                    cap.AddAdditionalCapability("appWaitActivity", "com.astra.slic.guest.GuestActivity");

                    driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap, TimeSpan.FromMinutes(5));
                    Thread.Sleep(4000);
                }
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                waity = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(90));
                Wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
                wait1 = new WebDriverWait(driver, TimeSpan.FromMinutes(5));

                try
                {
                    GlobalVariables.passed = 0;
                    GlobalVariables.faild = 0;
                    GlobalVariables.countOfTestMethods = 0;

                    GlobalVariables.name = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    GlobalVariables.Filename = AppDomain.CurrentDomain.BaseDirectory + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + f1 + ".xlsx";
                    GlobalVariables.prjpath = AppDomain.CurrentDomain.BaseDirectory + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".dll";
                    GlobalVariables.dct.CreateExcel(ref GlobalVariables.Filename, ref g1, ref GlobalVariables.r);
                    goto login;

                    continue00:
                    if (Category == "NON POS")
                        goto NONPOS;
                    if (Category == "POS")
                        goto POS;

                    continue0:
                    if (Life_Type == "For Own Life" || Life_Type == "For Other Life")
                        goto Life_Type;
                 
                    continue1:
                    if (Proposal_Type == "Existing_Customer")
                        goto Existing_Customer;
                    if (Proposal_Type == "New Customer")
                        goto New_Customer;

                    continue3:
                    goto Logout;

                    login:

                    //Registered_User
                    start(); methodnamefiningfunction("Clicking Registered_User");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("registerBut")));
                    driver.FindElement(By.Id("registerBut")).Click();
                    End();

                    //Employee_Id
                    start(); methodnamefiningfunction("Entering Employee_Id");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='Employee Id']")));
                    driver.FindElement(By.XPath("//*[@text='Employee Id']")).SendKeys("S1058065");
                    End();

                    //Password
                    start(); methodnamefiningfunction("Entering Password");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='Password']")));
                    driver.FindElement(By.XPath("//*[@text='Password']")).SendKeys("shriram");
                    End();

                    //Login
                    start(); methodnamefiningfunction("Clicking Login");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnlogin")));
                    driver.FindElement(By.Id("btnlogin")).Click();
                    End();

                    //Close
                    try
                    {
                        //wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("closedeposit")));
                        //driver.FindElement(By.Id("closedeposit")).Click();

                        //wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("closeButton")));
                        //driver.FindElement(By.Id("closeButton")).Click();
                    }
                    catch { }

                    //Menu
                    start(); methodnamefiningfunction("Clicking Menu");
                    wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.ImageButton[@index='0']")));
                    driver.FindElement(By.XPath("//android.widget.ImageButton[@index='0']")).Click();
                    End();

                    //Proposal
                    start(); methodnamefiningfunction("Clicking Proposal");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='PROPOSALS']")));
                    driver.FindElement(By.XPath("//*[@text='PROPOSALS']")).Click();
                    End();

                    //try
                    //{
                    //    wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='DISMISS']")));
                    //    driver.FindElement(By.XPath("//*[@text='DISMISS']")).Click();
                    //}
                    //catch
                    //{

                    //}

                    //Add_Proposal
                    start(); methodnamefiningfunction("Clicking Add_Proposal");
                    wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("fab")));
                    driver.FindElement(By.Id("fab")).Click();
                    End();

                    goto continue00;

                    NONPOS:
                    start(); methodnamefiningfunction("Clicking NONPOS");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Category + "']")).Click();
                    End();

                    goto continue0;

                    POS:
                    start(); methodnamefiningfunction("Clicking POS");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Category + "']")).Click();
                    End();

                    goto continue0;

                    Life_Type:

                    start(); methodnamefiningfunction("Clicking Life_type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Life_Type + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Life_Type + "']")).Click();
                    End();

                    goto continue1;             

                    Existing_Customer:

                    start(); methodnamefiningfunction("Clicking Existing Customer");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='EXISTING CUSTOMER']")));
                    driver.FindElement(By.XPath("//*[@text='EXISTING CUSTOMER']")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("existingBut")));
                    driver.FindElement(By.Id("existingBut")).Click();

                    goto continue1;

                    New_Customer:

                    if(Category == "POS")
                    {
                        AstraPOS pos = new AstraPOS();
                        pos.Pos_category();
                    }
                    if (Category == "NON POS")
                    {
                        AstraNonPos NonPos = new AstraNonPos();
                        NonPos.Astra_NonPos();
                    }
                   
                    goto continue3;

                    Logout:

                    driver.ResetApp();

                    Console.WriteLine("Iteration-" + g);

                    try
                    {
                        command = new SqlCommand("update " + tablename + " set status = 'Success' where g =" + temp, con);
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception) { }

                    GlobalVariables.dct.endtime_method();
                    GlobalVariables.dct.linkforbackscreen();
                    GlobalVariables.dct.overallstatus_pass(ref GlobalVariables.r, g, ref GlobalVariables.link, Expected_Status, testcaseid, Sl_No, Testcase_Description);
                    GlobalVariables.dct.excelclosefunction();

                }
                catch (Exception ex)
                {
                    try
                    {
                        driver.FindElement(By.Id("calculateButton")).Click(); Thread.Sleep(1000);
                        IWebElement toast = driver.FindElement(By.XPath("//android.widget.Toast[1]"));
                        string text = toast.Text;
                    }
                    catch { }

                    var screen = ((ITakesScreenshot)driver).GetScreenshot();
                    GlobalVariables.link = "\\\\192.169.1.55\\Automation reports\\SLIC_Mobile\\SLIC_SO_Proposal\\ISSUE" + g1 + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png";
                    screen.SaveAsFile(GlobalVariables.link);


                    StreamWriter objWriter = default(StreamWriter);
                    string filename = "\\\\192.169.1.55\\Automation reports\\SLIC_Mobile\\SLIC_SO_Proposal\\ISSUE" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + g + ".txt";
                    Console.WriteLine(ex.Message);
                    if ((!System.IO.Directory.Exists(filename)))
                    {
                        objWriter = File.CreateText(filename);
                        objWriter.WriteLine(ex.ToString());
                        objWriter.Close();
                    }

                    GlobalVariables.dct.callingcommanmethod(GlobalVariables.name, GlobalVariables.methodname);
                    GlobalVariables.dct.endtimefunction1(ref GlobalVariables.link, ref GlobalVariables.faild, ref GlobalVariables.countOfTestMethods, ref GlobalVariables.passed, ref g1, ref GlobalVariables.r);

                    //// Added for Reports- for fail iteration
                    //*******************************************************************************************

                    GlobalVariables.dct.endtime_method();
                    GlobalVariables.dct.overallstatus_fail(ref GlobalVariables.r, g, ref GlobalVariables.link, Expected_Status, testcaseid, Sl_No, Testcase_Description);

                    //*******************************************************************************************
                    GlobalVariables.dct.excelclosefunction();
                }

                driver.ResetApp();

                string[] ary = new string[2];
                ary = new string[] { "balaji.s@novactech.in" };
                string[] ary1 = new string[9];
                ary1 = new string[] { };
                string[] ary2 = new string[3];
                ary2 = new string[] { };


                GlobalVariables.dct.reportcalculation(ref GlobalVariables.totalsteps, GlobalVariables.r, ref GlobalVariables.countOfTestMethods, ref GlobalVariables.passed, ref GlobalVariables.faild);
                int rr = GlobalVariables.r - 1;

                ///''''''''''''''''''''''''If the value of g matches with rr then mail will be sent''''''''''''''''''''''''

                if (g == (GlobalVariables.r - 1))
                {
                    driver.Quit();
                    GlobalVariables.dct.mail(appname, url, GlobalVariables.totalsteps, ref prjname, ref nagvpath, ref GlobalVariables.Filename, ref GlobalVariables.r, ref GlobalVariables.faild, ref GlobalVariables.countOfTestMethods, ref GlobalVariables.passed, ary, ary1, ary2);
                    command = new SqlCommand("update Execution_Details set status = 'Success' where Pk_Id =" + Pk_Id, con);
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    command.ExecuteNonQuery();
                    con.Close();
                }

                GC.Collect();
            }
        }
        public void Medical_Details()
        {
            swipes swipe_Fn = new swipes(driver);

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

            scroll("halfdown");

            if (Any_Harmful_Drugs == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Any_Harmful_Drugs");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodryes")));
                driver.FindElement(By.Id("radiodryes")).Click();

                //Remarks
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtdrYes")));
                driver.FindElement(By.Id("edtdrYes")).Click();
                driver.FindElement(By.Id("edtdrYes")).SendKeys(Any_Harmful_Drugs_Provide_Details);
                End();
                scroll("halfdown");
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Any_Harmful_Drugs");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodrno")));
                driver.FindElement(By.Id("radiodrno")).Click();
                End();
            }
           
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
            }

            if (Any_leave_from_your_service_on_medical_grounds == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Any_leave_from_your_service_on_medical_grounds");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiomedyes")));
                driver.FindElement(By.Id("radiomedyes")).Click();

                //Remarks
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtmedYes")));
                driver.FindElement(By.Id("edtmedYes")).Click();
                driver.FindElement(By.Id("edtmedYes")).SendKeys(Any_leave_from_your_service_on_medical_grounds_provide_details);
                End();
                scroll("halfdown");
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Any_leave_from_your_service_on_medical_grounds");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiomedno")));
                driver.FindElement(By.Id("radiomedno")).Click();
                End();
            }

            if(Any_accident_or_injury_that_required_any_medical_treatment == "Yes")
            {
                start(); methodnamefiningfunction("Clicking any_accident_or_injury_that_required_any_medical_treatment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioaccyes")));
                driver.FindElement(By.Id("radioaccyes")).Click();

                //Remarks
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtaccYes")));
                driver.FindElement(By.Id("edtaccYes")).Click();
                driver.FindElement(By.Id("edtaccYes")).SendKeys(Any_accident_or_injury_that_required_any_medical_treatment_provide_details);
                End();
                scroll("halfdown");
            }
            else
            {
                start(); methodnamefiningfunction("Clicking any_accident_or_injury_that_required_any_medical_treatment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioaccno")));
                driver.FindElement(By.Id("radioaccno")).Click();
                End();
            }
            scroll("halfdown");

            if (LA_Gender == "Female")
            {
                //Gynaecological_Disorder
                if (Currently_Pregnant == "Yes")
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Gynaecological_Disorder");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("currentpregnantyes")));
                    driver.FindElement(By.Id("currentpregnantyes")).Click();
                    End();

                    scroll("halfdown");

                    //Remarks-Number_of_weeks_of_Pregnancy
                    start(); methodnamefiningfunction("Entering Remark");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("currentpregnantDetails")));
                    driver.FindElement(By.Id("currentpregnantDetails")).Click();
                    driver.FindElement(By.Id("currentpregnantDetails")).SendKeys(Remarks_for_Pregnant);
                    End();
            
                }
                else
                {
                    //No
                    start(); methodnamefiningfunction("Entering No");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("currentpregnantno")));
                    driver.FindElement(By.Id("currentpregnantno")).Click();
                    End();
                }

                scroll("down");
                
                //Miscarriages
                if (Miscarriages == "Yes")
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Miscarriages");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rGmiscarriagesYes")));
                    driver.FindElement(By.Id("rGmiscarriagesYes")).Click();
                    End();

                    scroll("halfdown");

                    //Remark
                    start(); methodnamefiningfunction("Entering Remark");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("datehismisca")));
                    driver.FindElement(By.Id("datehismisca")).Click();
                    Miscarriage_Date(Date_for_Miscarriages);
                    End();                  
                }
                else
                {
                    scroll("halfdown");
                    //No
                    start(); methodnamefiningfunction("Entering No");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rGmiscarriagesNo")));
                    driver.FindElement(By.Id("rGmiscarriagesNo")).Click();
                    End();
                }

                //Delivered a Baby
                if (Delivered_a_Baby == "Yes")
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Delivered_a_Baby");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rGdeliverbabyrecentYes")));
                    driver.FindElement(By.Id("rGdeliverbabyrecentYes")).Click();
                    End();
                    
                    //Remark
                    start(); methodnamefiningfunction("Entering Remark");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("datedelbabyrec")));
                    driver.FindElement(By.Id("datedelbabyrec")).Click();
                    Delivered_Baby_Date(Date_for_Delivered_a_Baby);
                    End();

                    scroll("halfdown");
                }
                else
                {
                    //No
                    start(); methodnamefiningfunction("Entering No");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rGdeliverbabyrecentNo")));
                    driver.FindElement(By.Id("rGdeliverbabyrecentNo")).Click();
                    End();
                }

                scroll("halfdown");

                if (Had_any_gynaecological_problems_requiring_treatment == "Yes")
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Had_any_gynaecological_problems_requiring_treatment");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rgGynaecologicalYes")));
                    driver.FindElement(By.Id("rgGynaecologicalYes")).Click();
                    End();

                    //Remarks-Had_any_gynaecological_problems_requiring_treatment
                    start(); methodnamefiningfunction("Entering Remark-Had_any_gynaecological_problems_requiring_treatment");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtGynaecologicalDetails")));
                    driver.FindElement(By.Id("edtGynaecologicalDetails")).Click();
                    driver.FindElement(By.Id("edtGynaecologicalDetails")).SendKeys(Had_any_gynaecological_problems_requiring_treatment_provide_details);
                    End();

                    scroll("halfdown");
                }
                else
                {
                    //No
                    start(); methodnamefiningfunction("Entering Had_any_gynaecological_problems_requiring_treatment");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("rgGynaecologicalNo")));
                    driver.FindElement(By.Id("rgGynaecologicalNo")).Click();
                    End();
                }
            }

            //Have you ever suffered from any ailments as mentioned below

            //Ailments relating to heart
            if (Ailments_relating_to_heart == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Ailments_relating_to_heart");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioaildesyes")));
                driver.FindElement(By.Id("radioaildesyes")).Click();
                End();

                //Remarks-Ailments_relating_to_heart
                start(); methodnamefiningfunction("Entering Remark-Ailments_relating_to_heart");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtaildesdYes")));
                driver.FindElement(By.Id("edtaildesdYes")).Click();
                driver.FindElement(By.Id("edtaildesdYes")).SendKeys(Ailments_relating_to_heart_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Ailments_relating_to_heart");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioaildesno")));
                driver.FindElement(By.Id("radioaildesno")).Click();
                End();
            }

            scroll("halfdown");

            if (Tested_positive_for_Hepatitis_B == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Tested_positive_for_Hepatitis_B");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiohivaidsyes")));
                driver.FindElement(By.Id("radiohivaidsyes")).Click();
                End();

                //Remarks-Tested_positive_for_Hepatitis_B
                start(); methodnamefiningfunction("Entering Remark-Ailments_relating_to_heart");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edthivaidsYes")));
                driver.FindElement(By.Id("edthivaidsYes")).Click();
                driver.FindElement(By.Id("edthivaidsYes")).SendKeys(Tested_positive_for_Hepatitis_B_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Tested_positive_for_Hepatitis_B");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiohivaidsno")));
                driver.FindElement(By.Id("radiohivaidsno")).Click();
                End();
            }

            if (Other_Respiratory_disorders == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Other_Respiratory_disorders");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiordyes")));
                driver.FindElement(By.Id("radiordyes")).Click();
                End();

                //Remarks-Other_Respiratory_disorders
                start(); methodnamefiningfunction("Entering Remark-Other_Respiratory_disorders");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtrdYes")));
                driver.FindElement(By.Id("edtrdYes")).Click();
                driver.FindElement(By.Id("edtrdYes")).SendKeys(Other_Respiratory_disorders_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Other_Respiratory_disorders");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiordno")));
                driver.FindElement(By.Id("radiordno")).Click();
                End();
            }

            scroll("halfdown");

            if (Diabetes_and_Low_BP == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Diabetes_and_Low_BP");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodiayes")));
                driver.FindElement(By.Id("radiodiayes")).Click();
                End();

                //Remarks-Diabetes_and_Low_BP
                start(); methodnamefiningfunction("Entering Remark-Diabetes_and_Low_BP");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtdiaYes")));
                driver.FindElement(By.Id("edtdiaYes")).Click();
                driver.FindElement(By.Id("edtdiaYes")).SendKeys(Diabetes_and_Low_BP_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Diabetes_and_Low_BP");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiodiano")));
                driver.FindElement(By.Id("radiodiano")).Click();
                End();
            }

            if(Musculoskeletal_disorders == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Musculoskeletal_disorders");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiobloodyes")));
                driver.FindElement(By.Id("radiobloodyes")).Click();
                End();

                //Remarks-Musculoskeletal_disorders
                start(); methodnamefiningfunction("Entering Remark-Diabetes_and_Low_BP");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtbloodYes")));
                driver.FindElement(By.Id("edtbloodYes")).Click();
                driver.FindElement(By.Id("edtbloodYes")).SendKeys(Musculoskeletal_disorders_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Musculoskeletal_disorders");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radiobloodno")));
                driver.FindElement(By.Id("radiobloodno")).Click();
                End();
                scroll("halfdown");
            }

            if(Ailment_that_required_treatment == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Ailment_that_required_treatment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioillailyes")));
                driver.FindElement(By.Id("radioillailyes")).Click();
                End();

                //Remarks-Ailment_that_required_treatment
                start(); methodnamefiningfunction("Entering Remark-Ailment_that_required_treatment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtillailYes")));
                driver.FindElement(By.Id("edtillailYes")).Click();
                driver.FindElement(By.Id("edtillailYes")).SendKeys(Ailment_that_required_treatment_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Ailment_that_required_treatment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioillailno")));
                driver.FindElement(By.Id("radioillailno")).Click();
                End();
            }

            scroll("halfdown");

            if (Any_disorder_of_Eye == "Yes")
            {
                //Yes
                start(); methodnamefiningfunction("Entering Any_disorder_of_Eye");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioeyearyes")));
                driver.FindElement(By.Id("radioeyearyes")).Click();
                End();

                //Remarks-Any_disorder_of_Eye
                start(); methodnamefiningfunction("Entering Remark-Any_disorder_of_Eye");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edteyearYes")));
                driver.FindElement(By.Id("edteyearYes")).Click();
                driver.FindElement(By.Id("edteyearYes")).SendKeys(Any_disorder_of_Eye_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                //No
                start(); methodnamefiningfunction("Entering Any_disorder_of_Eye");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioeyearno")));
                driver.FindElement(By.Id("radioeyearno")).Click();
                End();
            }

            scroll("halfdown");

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
                    scroll("halfdown");
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

        }

        public void Communication_details()
        {
            //Permanent_Address
            //Door_No

            //Pincode
            start(); methodnamefiningfunction("Entering Pincode");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edpropincode")));
            driver.FindElement(By.Id("edpropincode")).SendKeys(Pincode_Permanent_Address);

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnproSearch")));
            driver.FindElement(By.Id("btnproSearch")).Click();
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnproSearch")));
            driver.FindElement(By.Id("btnproSearch")).Click();
            End();

            if (Area_Permanent_Address != "")
            {
                //Area
                start(); methodnamefiningfunction("Entering Area");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edproarea")));
                driver.FindElement(By.Id("edproarea")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Area_Permanent_Address + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Area_Permanent_Address + "']")).Click();
                End();
            }
            scroll("down");

            //Same
            if (Copy_Communication_Address_as_Permanent_Address == "No")
            {
                //Comm_DooNo
                start(); methodnamefiningfunction("Entering Comm_DooNo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtcorresStreetName")));
                driver.FindElement(By.Id("edtcorresStreetName")).SendKeys(Door_No_Communication_Address);
                End();

                //Comm_Street
                start(); methodnamefiningfunction("Entering Comm_DooNo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtcorresStreetName2")));
                driver.FindElement(By.Id("edtcorresStreetName2")).SendKeys(Street_Communication_Address);
                End();

                //Comm_Pincode
                start(); methodnamefiningfunction("Entering Pincode");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edpincode")));
                driver.FindElement(By.Id("edpincode")).SendKeys(Pincode_Communication_Address);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnSearch")));
                driver.FindElement(By.Id("btnSearch")).Click();
                End();

                scroll("down");

                //Comm_Area
                start(); methodnamefiningfunction("Entering Area");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edarea")));
                driver.FindElement(By.Id("edarea")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Area_Communication_Address + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Area_Communication_Address + "']")).Click();
                End();
            }
            else if (Copy_Communication_Address_as_Permanent_Address == "Yes")
            {
                start(); methodnamefiningfunction("Clicking same_Address");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("checkAddressConfirm")));
                driver.FindElement(By.Id("checkAddressConfirm")).Click();
                End();
            }

            if (Life_Type == "For Other Life")
            {
                Other_LifeAddress();
            }

            //LA_Mobile_No
            start(); methodnamefiningfunction("Entering LA_Mobile_No");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMobileNoLA")));
            driver.FindElement(By.Id("edtMobileNoLA")).SendKeys(LA_Mobile_No);

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnmobileverify")));
            driver.FindElement(By.Id("btnmobileverify")).Click();
            Thread.Sleep(3000);

            //try
            //{
            //    if (Relationship == "Self")
            //    {
            //        wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Relationship + "']")));
            //        driver.FindElement(By.XPath("//*[@text='" + Relationship + "']")).Click();

            //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnrelationok")));
            //        driver.FindElement(By.Id("btnrelationok")).Click();

            //        //
            //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtselfmobno")));
            //        driver.FindElement(By.Id("edtselfmobno")).SendKeys(Reason_Self);

            //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnselfmobnook")));
            //        driver.FindElement(By.Id("btnselfmobnook")).Click();
            //    }
            //    else
            //    {
            //        wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Relationship + "']")));
            //        driver.FindElement(By.XPath("//*[@text='" + Relationship + "']")).Click();

            //        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnrelationok")));
            //        driver.FindElement(By.Id("btnrelationok")).Click();
            //    }
            //}
            //catch { }

            End();

            //Whatsapp
            if (Whatsapp_Contact == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Whatsapp_Contact");
                wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioGroupWhatsAppYes")));
                driver.FindElement(By.Id("radioGroupWhatsAppYes")).Click();
                End();
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Whatsapp_Contact");
                wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioGroupWhatsAppNo")));
                driver.FindElement(By.Id("radioGroupWhatsAppNo")).Click();
                End();
            }

            if (Life_Type == "For Other Life")
            {
                start(); methodnamefiningfunction("Entering LA_Mobile_No");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMobileNo")));
                driver.FindElement(By.Id("edtMobileNo")).SendKeys(LA_Mobile_No);

                scroll("down");

                wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnmobileverifyprop")));
                driver.FindElement(By.Id("btnmobileverifyprop")).Click();
                End();

                Thread.Sleep(2000);
                scroll("down");

            }
            Thread.Sleep(2000);
            if (Educational_Qualification != "")
            {
                //Education
                start(); methodnamefiningfunction("Entering Education");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("eduicationSpinId")));
                driver.FindElement(By.Id("eduicationSpinId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Educational_Qualification + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Educational_Qualification + "']")).Click();
                End();
            }
            scroll("halfdown");

            if (Occupation != "")
            {
                //Occupation
                start(); methodnamefiningfunction("Entering Occupation");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("occupationSpinIdd")));
                driver.FindElement(By.Id("occupationSpinIdd")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Occupation + "']")).Click();
                End();
            }
            Thread.Sleep(2000);

            scroll("down");

            //Occupation-Cat
            start(); methodnamefiningfunction("Entering Occupation-Cat");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("occupationSubSpinIdd")));
            driver.FindElement(By.Id("occupationSubSpinIdd")).Click();
            End();

            //if (LA_Gender == "Female")
            //{
            //    start(); methodnamefiningfunction("Entering Occupation-Driver");
            //    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
            //    driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
            //    End();
            //}                
            if (Occupation_Sub_Category == "Health Care Professional")
            {
                //Occupation_Sub_Category
                Thread.Sleep(500);
                start(); methodnamefiningfunction("Entering Occupation_Sub_Category-Health Care Professional");
                try {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                              + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                }
                catch
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                }
                
                End();

                //Medical_Specialty
                start(); methodnamefiningfunction("Entering Medical_Specialty");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Medical_Specialty")));
                driver.FindElement(By.Id("Medical_Specialty")).Click();
                driver.FindElement(By.Id("Medical_Specialty")).SendKeys(Medical_Specialty);
                End();

                //Exact_Nature
                start(); methodnamefiningfunction("Entering Exact_Nature");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Exact_nature")));
                driver.FindElement(By.Id("Exact_nature")).Click();
                driver.FindElement(By.Id("Exact_nature")).SendKeys(Exact_Nature);
                End();

                //Name_and_Address_of_healthcare_facility
                start(); methodnamefiningfunction("Entering Name_and_Address_of_healthcare_facility");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Name_and_address")));
                driver.FindElement(By.Id("Name_and_address")).Click();
                driver.FindElement(By.Id("Name_and_address")).SendKeys(Name_and_Address_of_healthcare_facility);
                End();

                //Name_of_Health_Authority
                start(); methodnamefiningfunction("Entering Name_of_Health_Authority");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Health_Authority")));
                driver.FindElement(By.Id("Health_Authority")).Click();
                driver.FindElement(By.Id("Health_Authority")).SendKeys(Name_of_Health_Authority);
                End();

                //Sufficient_PPE
                if (Sufficient_PPE == "Yes")
                {
                    start(); methodnamefiningfunction("Sufficient_PPE");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("ppeYes")));
                    driver.FindElement(By.Id("ppeYes")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Entering Sufficient_PPE");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("ppeNo")));
                    driver.FindElement(By.Id("ppeNo")).Click();
                    End();
                }

                scroll("down");

                //Diagnosed_with_Noval_Coronavirus
                if (Diagnosed_with_Noval_Coronavirus == "Yes")
                {
                    start(); methodnamefiningfunction("Diagnosed_with_Noval_Coronavirus");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covidYes")));
                    driver.FindElement(By.Id("covidYes")).Click();
                    End();

                    //Nature_of_Work_With_Covid
                    start(); methodnamefiningfunction("Diagnosed_with_Noval_Coronavirus");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covid1_yes_et")));
                    driver.FindElement(By.Id("covid1_yes_et")).Click();
                    driver.FindElement(By.Id("covid1_yes_et")).SendKeys(Nature_of_Work_With_Covid);
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Entering Diagnosed_with_Noval_Coronavirus");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covidNo")));
                    driver.FindElement(By.Id("covidNo")).Click();
                    End();
                }
                scroll("halfdown");
                //SickLeave_due_to_Noval_Coronavirus
                if (SickLeave_due_to_Noval_Coronavirus == "Yes")
                {
                    start(); methodnamefiningfunction("SickLeave_due_to_Noval_Coronavirus");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covidYes1")));
                    driver.FindElement(By.Id("covidYes1")).Click();
                    End();

                    //Specify_Adversity_Noted
                    start(); methodnamefiningfunction("Specify_Adversity_Noted");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covid2_yes_et")));
                    driver.FindElement(By.Id("covid2_yes_et")).Click();
                    driver.FindElement(By.Id("covid2_yes_et")).SendKeys(Specify_Adversity_Noted);
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Entering SickLeave_due_to_Noval_Coronavirus");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covidNo2")));
                    driver.FindElement(By.Id("covidNo2")).Click();
                    End();
                }

                scroll("halfdown");

                //Good_health_Actively_at_Work
                if (Good_health_Actively_at_Work == "Yes")
                {
                    start(); methodnamefiningfunction("Good_health_Actively_at_Work");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("goodhealthYes")));
                    driver.FindElement(By.Id("goodhealthYes")).Click();
                    End();
                }
                else
                {
                    start(); methodnamefiningfunction("Entering Good_health_Actively_at_Work");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("goodhealthNo")));
                    driver.FindElement(By.Id("goodhealthNo")).Click();
                    End();
                    
                    //Specify_Adversity_Noted
                    start(); methodnamefiningfunction("Good_health_Actively_at_Work-Specify_Adversity_Noted");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("covid2_yes_et")));
                    driver.FindElement(By.Id("covid2_yes_et")).Click();
                    driver.FindElement(By.Id("covid2_yes_et")).SendKeys(Good_health_Specify_Adversity_Noted);
                    End();
                }

                scroll("halfdown");

                //Save
                start(); methodnamefiningfunction("Entering Save");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("okbutton")));
                driver.FindElement(By.Id("okbutton")).Click();
                End();


            }
            if (Occupation_Sub_Category == "Driver")
            {
                start(); methodnamefiningfunction("Entering Occupation-Driver");
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                              + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                }
                catch
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                }
                End();

                //Vehicle_Driven
                start(); methodnamefiningfunction("Entering Vehicle_Driven");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtDriver1")));
                driver.FindElement(By.Id("edtDriver1")).SendKeys(Driver_Type);
                End();

                //Driver_kilometer
                start(); methodnamefiningfunction("Entering Driver_kilometer");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtDriver2")));
                driver.FindElement(By.Id("edtDriver2")).SendKeys(Driver_kilometer);
                End();

                //Driver_limits
                start(); methodnamefiningfunction("Entering Driver_limits");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtDriver3")));
                driver.FindElement(By.Id("edtDriver3")).SendKeys(Driver_limits);
                End();

                //Driver_public Carriers
                start(); methodnamefiningfunction("Entering Driver_public");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Driver4")));
                driver.FindElement(By.Id("Driver4")).Click();
                End();

                if (Driver_public == "Goods" || Driver_public == "Passenger")
                {
                    start(); methodnamefiningfunction("Entering Driver_public-Goods/Passengers");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Driver_public + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Driver_public + "']")).Click();
                    End();

                    //Driver_National Permit
                    start(); methodnamefiningfunction("Entering Driver_National");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("Driver5")));
                    driver.FindElement(By.Id("Driver5")).Click();


                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Driver_National + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Driver_National + "']")).Click();
                    End();

                    //Save
                    start(); methodnamefiningfunction("Entering Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("okbutton")));
                    driver.FindElement(By.Id("okbutton")).Click();
                    End();
                }

            }
            else
            {
                if (Occupation_Sub_Category == "Others")
                {
                    start(); methodnamefiningfunction("Entering Others");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtOccSubFree")));
                    driver.FindElement(By.Id("edtOccSubFree")).SendKeys(Others);
                    End();
                    scroll("halfdown");
                }
                else
                    if (Occupation_Sub_Category == "Self Employed Business")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    End();

                    //Business_Type
                    start(); methodnamefiningfunction("Entering Business_Type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edTypBus")));
                    driver.FindElement(By.Id("edTypBus")).SendKeys(Type_of_Business);
                    End();

                    //Save
                    start(); methodnamefiningfunction("Entering Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("okbutton")));
                    driver.FindElement(By.Id("okbutton")).Click();
                    End();

                }
                else if (Occupation_Sub_Category == "Police(IPS)" || Occupation_Sub_Category == "Office Work" || Occupation_Sub_Category == "Lineman" || Occupation_Sub_Category == "Teacher" || Occupation_Sub_Category == "Architects" || Occupation_Sub_Category == "Charted Accountant" || Occupation_Sub_Category == "Doctor" || Occupation_Sub_Category == "Engineer" || Occupation_Sub_Category == "Lawyers" || Occupation_Sub_Category == "Consultants" || Occupation_Sub_Category == "Professors" || Occupation_Sub_Category == "Agriculture")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    End();
                }
                else if (Occupation_Sub_Category == "Armed forces/BSF/CRPF/Assam Rifles/Greyhounds")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    End();

                    start(); methodnamefiningfunction("Entering Rank");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsalary1")));
                    driver.FindElement(By.Id("edtsalary1")).SendKeys(Rank);
                    End();

                    start(); methodnamefiningfunction("Entering Work_Location");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsalary2")));
                    driver.FindElement(By.Id("edtsalary2")).SendKeys(Current_Work_Location);
                    End();

                    start(); methodnamefiningfunction("Entering Current_Nature");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsalary3")));
                    driver.FindElement(By.Id("edtsalary3")).Clear();
                    driver.FindElement(By.Id("edtsalary3")).SendKeys(Current_Nature);
                    End();

                    start(); methodnamefiningfunction("Entering Special assignment");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsalary4")));
                    driver.FindElement(By.Id("edtsalary4")).SendKeys(Special_Assignment);
                    End();

                    start(); methodnamefiningfunction("Clicking Job");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("questions5")));
                    driver.FindElement(By.Id("questions5")).Click();
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Job + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Job + "']")).Click();

                    if (Job == "Yes")
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtsalary4")));
                        driver.FindElement(By.Id("edthazardous")).SendKeys(Job_If_Yes);
                    }
                    End();

                    start(); methodnamefiningfunction("Clicking carries_Gun");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("questions6")));
                    driver.FindElement(By.Id("questions6")).Click();
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + carries_Gun + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + carries_Gun + "']")).Click();
                    End();

                    //Save
                    start(); methodnamefiningfunction("Clicking Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                    driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                    End();
                }
                else if (Occupation_Sub_Category == "Navy")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    End();

                    start(); methodnamefiningfunction("Entering Rank_Navy");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtnavy1")));
                    driver.FindElement(By.Id("edtnavy1")).SendKeys(Rank_Navy);
                    End();

                    start(); methodnamefiningfunction("Entering Exact_Nature_Navy");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtnavy2")));
                    driver.FindElement(By.Id("edtnavy2")).SendKeys(Exact_Nature_Navy);
                    End();

                    //Save
                    start(); methodnamefiningfunction("Clicking Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                    driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                    End();
                }
                else
                if (Occupation_Sub_Category == "Airforce")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    End();

                    start(); methodnamefiningfunction("Entering Rank_Air");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAir1")));
                    driver.FindElement(By.Id("edtAir1")).SendKeys(Rank_Air);
                    End();

                    start(); methodnamefiningfunction("Entering Duty_Air");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAir2")));
                    driver.FindElement(By.Id("edtAir2")).SendKeys(Duty_Air);
                    End();

                    start(); methodnamefiningfunction("Entering Aircraft_Type");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAir3")));
                    driver.FindElement(By.Id("edtAir3")).SendKeys(Aircraft_Type);
                    End();

                    //Special_Asssignment_Air
                    start(); methodnamefiningfunction("Clicking Special_Asssignment_Air");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAir4")));
                    driver.FindElement(By.Id("edtAir4")).Click();
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Special_Asssignment_Air + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Special_Asssignment_Air + "']")).Click();
                    End();

                    //Save
                    start(); methodnamefiningfunction("Clicking Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                    driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                    End();
                }
                else if (Occupation_Sub_Category == "Merchant Marine")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    End();

                    start(); methodnamefiningfunction("Entering Cargo_Marine");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMarine1")));
                    driver.FindElement(By.Id("edtMarine1")).SendKeys(Cargo_Marine);
                    End();

                    start(); methodnamefiningfunction("Entering Cargo_Job");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMarine2")));
                    driver.FindElement(By.Id("edtMarine2")).SendKeys(Job_Marine);
                    End();

                    start(); methodnamefiningfunction("Clicking Vessel_Marine");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMarine3")));
                    driver.FindElement(By.Id("edtMarine3")).Click();

                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                           + "new UiSelector().text(\"" + Vessel_Marine + "\"));").Click();
                    Thread.Sleep(500);
                    End();

                    //Save
                    start(); methodnamefiningfunction("Clicking Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                    driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                    End();
                }
                else if (Occupation_Sub_Category == "Oil and Gas Rig worker")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    End();

                    start(); methodnamefiningfunction("Clicking Offshore_Oil");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtOil1")));
                    driver.FindElement(By.Id("edtOil1")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Offshore_Oil + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Offshore_Oil + "']")).Click();
                    End();

                    if (Offshore_Oil == "Yes")
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtoffshore")));
                        driver.FindElement(By.Id("edtoffshore")).Click();
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Offshore_Oil_Yes + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Offshore_Oil_Yes + "']")).Click();

                    }

                    start(); methodnamefiningfunction("Clicking Travel_Oil");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtOil2")));
                    driver.FindElement(By.Id("edtOil2")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Travel_Oil + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Travel_Oil + "']")).Click();
                    End();

                    if (Travel_Oil == "Yes")
                    {
                        start(); methodnamefiningfunction("Entering Time_Year");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edthelicopter1")));
                        driver.FindElement(By.Id("edthelicopter1")).Clear();
                        driver.FindElement(By.Id("edthelicopter1")).SendKeys(Time_Year);
                        End();

                        start(); methodnamefiningfunction("Entering Travel_Duration");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edthelicopter2")));
                        driver.FindElement(By.Id("edthelicopter2")).Clear();
                        driver.FindElement(By.Id("edthelicopter2")).SendKeys(Travel_Duration);
                        End();

                        //Save
                        start(); methodnamefiningfunction("Clicking Save");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                        driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                        End();
                    }

                }
                else if (Occupation_Sub_Category == "Mining")
                {
                    start(); methodnamefiningfunction("Entering OccupationCat");
                    try
                    {
                        driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                                  + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                    }
                    catch
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                        driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                    }
                    End();

                    start(); methodnamefiningfunction("Entering Time_Year");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMining1")));
                    driver.FindElement(By.Id("edtMining1")).SendKeys(Mine_Type);
                    End();

                    start(); methodnamefiningfunction("Clicking Involved_Mining");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMining4")));
                    driver.FindElement(By.Id("edtMining4")).Click();
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Involved_Mining + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Involved_Mining + "']")).Click();
                    End();
                    if (Involved_Mining == "Underground")
                    {
                        start(); methodnamefiningfunction("Entering Underground_Duty");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMining2")));
                        driver.FindElement(By.Id("edtMining2")).SendKeys(Underground_Duty);
                        End();

                        start(); methodnamefiningfunction("Entering Underground_WorkHr");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMining3")));
                        driver.FindElement(By.Id("edtMining3")).SendKeys(Underground_WorkHr);

                        End();

                        //Save
                        start(); methodnamefiningfunction("Clicking Save");
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                        driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                        End();
                    }
                    //Save
                    start(); methodnamefiningfunction("Clicking Save");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE']")));
                    driver.FindElement(By.XPath("//*[@text='SAVE']")).Click();
                    End();
                }
            }


            //Email
            start(); methodnamefiningfunction("Entering Email");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtLAEmailID")));
            driver.FindElement(By.Id("edtLAEmailID")).SendKeys(Email);
            End();

            if (Occupation_Sub_Category == "Housewife")
            {
                start(); methodnamefiningfunction("Entering OccupationCat");
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                              + "new UiSelector().text(\"" + Occupation_Sub_Category + "\"));").Click();
                }
                catch
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + Occupation_Sub_Category + "']")).Click();
                }
                End();

                start(); methodnamefiningfunction("Entering Husband_Occupation");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtHusOcc")));
                driver.FindElement(By.Id("edtHusOcc")).SendKeys(Husband_Occupation);
                End();

                start(); methodnamefiningfunction("Entering Husband_Occupation");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAnnual")));
                driver.FindElement(By.Id("edtAnnual")).SendKeys(Husband_Annual_Income);
                End();

                start(); methodnamefiningfunction("Entering Husband_Occupation");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtHusInsDetAmt")));
                driver.FindElement(By.Id("edtHusInsDetAmt")).SendKeys(Husband_Insurance_Detail_Amount);
                End();
            }
        }

        public void Nominee_Details()
        {
            //FirstName
            start(); methodnamefiningfunction("Entering FirstName");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtFrstName")));
            driver.FindElement(By.Id("edtFrstName")).Click();
            driver.FindElement(By.Id("edtFrstName")).SendKeys(First_Name_of_Nominee);
            End();
            
            //Nominee_Details
            if (Nominee_Title != "")
            {
                start(); methodnamefiningfunction("Entering Title");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("salutationId")));
                driver.FindElement(By.Id("salutationId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Nominee_Title + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Nominee_Title + "']")).Click();
                End();
            }

            scroll("halfdown");

            ////MiddleName
            //start(); methodnamefiningfunction("Entering MiddleName");
            //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtMiddleName")));
            //driver.FindElement(By.Id("edtMiddleName")).SendKeys(Middle_Name_of_Nominee);
            //End();

            //LastName
            start(); methodnamefiningfunction("Entering LastName");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtLastName")));
            driver.FindElement(By.Id("edtLastName")).SendKeys(Last_Name_of_Nominee);
            End();

            //gender
            start(); methodnamefiningfunction("clicking Nominee Gender");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("genderSpinId")));
            driver.FindElement(By.Id("genderSpinId")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Nominee_Gender + "']")));
            driver.FindElement(By.XPath("//*[@text='" + Nominee_Gender + "']")).Click();
            End();

            //DOB
            start();
            methodnamefiningfunction("Clicking DOB");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalender")));
            IWebElement dd = driver.FindElement(By.Id("dateCalender"));
            dd.Click();

            Nomine_DOB(Nominee_DOB);
            End();
            Thread.Sleep(2000);

            //Relationship
            if (Relationship_to_Assured != "")
            {
                start(); methodnamefiningfunction("Entering Relationship");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("relationShipIdLA")));
                driver.FindElement(By.Id("relationShipIdLA")).Click();
                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                            + "new UiSelector().text(\"" + Relationship_to_Assured + "\"));").Click();                    
                }
                catch { driver.FindElement(By.XPath("//*[@text='" + Relationship_to_Assured + "']")).Click(); }
              
                End();
            }

            string verifyAge = driver.FindElement(By.Id("edtNomineeAge")).Text;

            if (Convert.ToSingle(verifyAge) < 18)
            {
                //swipe
                scroll("halfdown");

                //AppointeeFName
                start(); methodnamefiningfunction("Entering AppointeeFName");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAppointeeFrtName")));
                driver.FindElement(By.Id("edtAppointeeFrtName")).SendKeys(AppointeeFName);
                End();

                ////AppointeeMName
                //start(); methodnamefiningfunction("Entering AppointeeMName");
                //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAppointeeMiddleName")));
                //driver.FindElement(By.Id("edtAppointeeMiddleName")).SendKeys(AppointeeMName);
                //End();

                //AppointeeLName
                start(); methodnamefiningfunction("Entering AppointeeLName");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAppointeeLastName")));
                driver.FindElement(By.Id("edtAppointeeLastName")).SendKeys(AppointeeLName);
                End();

                scroll("halfdown");

                //Appointee_Relationship
                start(); methodnamefiningfunction("Entering Relationship");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("relationShipIdAppointee")));
                driver.FindElement(By.Id("relationShipIdAppointee")).Click();

                try
                {
                    driver.FindElementByAndroidUIAutomator("new UiScrollable(new UiSelector()).scrollIntoView("
                            + "new UiSelector().text(\"" + Appointee_Relationship + "\"));").Click();
                }
                catch { driver.FindElement(By.XPath("//*[@text='" + Appointee_Relationship + "']")).Click(); }
                              
            }
        }

        public void Document_Upload()
        {
            //Digital_Signature
            start(); methodnamefiningfunction("Entering Digital_Signature");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("signId")));
            driver.FindElement(By.Id("signId")).Click();

            //
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("signature_pad")));
            driver.FindElement(By.Id("signature_pad")).Click();
            End();

            //Save
            start(); methodnamefiningfunction("Entering Save");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE SIGNATURE']")));
            driver.FindElement(By.XPath("//*[@text='SAVE SIGNATURE']")).Click();
            End();


            if (Latest_Photograph_of_Life_Assured == "Yes")
            {
                //Photo Upload
                start(); methodnamefiningfunction("Entering Photo Upload");
                wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("imgProposer")));
                driver.FindElement(By.Id("imgProposer")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='Choose from Library']")));
                driver.FindElement(By.XPath("//*[@text='Choose from Library']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }

            if (Selfie_Photo_graph == "Yes")
            {
                //Image
                start(); methodnamefiningfunction("Entering Image");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("imgselfie")));
                driver.FindElement(By.Id("imgselfie")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("org.codeaurora.snapcam:id/shutter_button")));
                driver.FindElement(By.Id("org.codeaurora.snapcam:id/shutter_button")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("org.codeaurora.snapcam:id/btn_done")));
                driver.FindElement(By.Id("org.codeaurora.snapcam:id/btn_done")).Click();

                //
                //SAVE
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }

            if (Life_Type == "For Other Life")
            {
                //life assured signature
                start(); methodnamefiningfunction("Clicking life assured signature");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtLifeAssSignature")));
                driver.FindElement(By.Id("edtLifeAssSignature")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='Draw Signature']")));
                driver.FindElement(By.XPath("//*[@text='Draw Signature']")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("signature_pad")));
                driver.FindElement(By.Id("signature_pad")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("save_button")));
                driver.FindElement(By.Id("save_button")).Click();
                End();

                if (Proposal_Photograph == "Yes")
                {
                    start(); methodnamefiningfunction("Clicking latest photo graph of Proposer");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("adhaarimgProposerLatest")));
                    driver.FindElement(By.Id("adhaarimgProposerLatest")).Click();


                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='Choose from Library']")));
                    driver.FindElement(By.XPath("//*[@text='Choose from Library']")).Click();

                    //
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                    driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                    //
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                    driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                    End();

                    //SAVE
                    start(); methodnamefiningfunction("Entering SAVE");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                    driver.FindElement(By.Id("savebutton")).Click();
                    End();

                    scroll("down");
                }
            }
            if (Life_Type == "For Own Life")
            {
                //
                start(); methodnamefiningfunction("Entering Signature");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("imgLifeAssuredImageUpload")));
                driver.FindElement(By.Id("imgLifeAssuredImageUpload")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='CHANGE']")));
                driver.FindElement(By.XPath("//*[@text='CHANGE']")).Click();
                End();

                //
                start(); methodnamefiningfunction("Entering Signature");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("signature_pad")));
                driver.FindElement(By.Id("signature_pad")).Click();
                End();

                //Save
                start(); methodnamefiningfunction("Entering Save");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='SAVE SIGNATURE']")));
                driver.FindElement(By.XPath("//*[@text='SAVE SIGNATURE']")).Click();
                End();

                Thread.Sleep(3000);
            }

            scroll("down");

            //Agree
            start(); methodnamefiningfunction("Entering Agree");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='I Agree Terms and Conditions']")));
            driver.FindElement(By.XPath("//*[@text='I Agree Terms and Conditions']")).Click();
            End();

            Thread.Sleep(3000);

            //Done
            start(); methodnamefiningfunction("Entering Done");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='OK']")));
            driver.FindElement(By.XPath("//*[@text='OK']")).Click();
            End();

            if (Life_Type == "For Other Life")
            {
                Proposal_Document();
            }
            if (Age_Proof_Upload == "Yes")
            {
                //Document_Upload 
                if (Age_Proof == "PAN Card - Standard")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtIdAgeProofNo")));
                    driver.FindElement(By.Id("edtIdAgeProofNo")).SendKeys(LA_PAN_Number);
                }
                else if (Age_Proof == "Passport - Standard")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtIdAgeProofNo")));
                    driver.FindElement(By.Id("edtIdAgeProofNo")).SendKeys("12457825");
                }
                else if (Age_Proof == "Driving License - Standard")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtIdAgeProofNo")));
                    driver.FindElement(By.Id("edtIdAgeProofNo")).SendKeys("TN214512789465");
                }
                else if (Age_Proof == "UID / Aadhaar Card - Standard")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtIdAgeProofNo")));
                    driver.FindElement(By.Id("edtIdAgeProofNo")).SendKeys(LA_Aadhar_Number);
                }

                start(); methodnamefiningfunction("Entering Document_Upload");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("ageButIdlife")));
                driver.FindElement(By.Id("ageButIdlife")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }
            //
            if (ID_Proof_Upload == "Yes")
            {
                start(); methodnamefiningfunction("Entering Photo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("laPhotoId")));
                driver.FindElement(By.Id("laPhotoId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + ID_Proof + "']")));
                driver.FindElement(By.XPath("//*[@text='" + ID_Proof + "']")).Click();
                if (ID_Proof == "Pan Card")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtIdProofNo")));
                    driver.FindElement(By.Id("edtIdProofNo")).SendKeys(LA_PAN_Number);
                }
                if (ID_Proof == "Passport")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderIdProof")));
                    driver.FindElement(By.Id("dateCalenderIdProof")).Click();

                    DOB_Passport(Passport_Expire_Date);
                }
                else if (ID_Proof == "Driving License")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderIdProof")));
                    driver.FindElement(By.Id("dateCalenderIdProof")).Click();

                    DOB_License(Driving_License_Expire_Date);
                }
                End();
            }
            //
            start(); methodnamefiningfunction("Entering Proof");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("laphotoProofScanId")));
            driver.FindElement(By.Id("laphotoProofScanId")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
            driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

            //
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
            driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

            //
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
            driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
            End();

            //SAVE
            start(); methodnamefiningfunction("Entering SAVE");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
            driver.FindElement(By.Id("savebutton")).Click();
            End();

            scroll("halfdown");

            //Address
            if (Addres_Proof_Upload == "Yes")
            {
                start(); methodnamefiningfunction("Entering Address");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("laAddressProof")));
                driver.FindElement(By.Id("laAddressProof")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Address_Proof + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Address_Proof + "']")).Click();
                if (Address_Proof == "")

                    if (Address_Proof == "AADHAR CARD")
                    {
                        Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtIdAddressProofNo")));
                        driver.FindElement(By.Id("edtIdAddressProofNo")).SendKeys(LA_Aadhar_Number);
                    }
                if (Address_Proof == "Passport")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderAddressProof")));
                    driver.FindElement(By.Id("dateCalenderAddressProof")).Click();

                    DOB_Passport(Passport_Expire_Date);
                }
                else if (Address_Proof == "Driving License")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderAddressProof")));
                    driver.FindElement(By.Id("dateCalenderAddressProof")).Click();

                    DOB_License(Driving_License_Expire_Date);
                }
                End();
            }
            //     
            start(); methodnamefiningfunction("Entering Address");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("laaddressScanId")));
            driver.FindElement(By.Id("laaddressScanId")).Click();

            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
            driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

            //
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
            driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

            //
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
            driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
            End();

            //SAVE
            start(); methodnamefiningfunction("Entering SAVE");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
            driver.FindElement(By.Id("savebutton")).Click();

            Thread.Sleep(2000);
            scroll("halfdown");
            End();

            //Income_Proof
            if (Income_Proof_Upload == "Yes")
            {
                start(); methodnamefiningfunction("Entering Income_Proof");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("laIncomeProof")));
                driver.FindElement(By.Id("laIncomeProof")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Income_Proof + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Income_Proof + "']")).Click();
                End();

                //     
                start(); methodnamefiningfunction("Entering Income");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("laincomeScanId")));
                driver.FindElement(By.Id("laincomeScanId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }

            scroll("down");

            //Passport_Proof
            if (Passport_Proof == "Yes" && Nationality == "NRI")
            {
                start(); methodnamefiningfunction("Clicking Passport_Proof");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("lapassportScanId")));
                driver.FindElement(By.Id("lapassportScanId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }

            //Declaration_Photo_Copy
            if (Declaration_Photo_Copy == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Declaration_Photo_Copy");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("docScanLay")));
                driver.FindElement(By.Id("docScanLay")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }

            //NACH_Doc
            if (NACH_Document_Upload == "Yes")
            {
                //1st Photo
                start(); methodnamefiningfunction("Entering Nach_Photo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nachLay")));
                driver.FindElement(By.Id("nachLay")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();

                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();

                //2nd Photo
                start(); methodnamefiningfunction("Entering Nach_Photo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nachBackLay")));
                driver.FindElement(By.Id("nachBackLay")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();

                //3rd Photo
                start(); methodnamefiningfunction("Entering Nach_Photo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("nachBankLay")));
                driver.FindElement(By.Id("nachBankLay")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();
                End();

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }
            scroll("halfdown");

            ////Registration_Type
            //start(); methodnamefiningfunction("Entering Registration_Type");
            //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("debitregistertype")));
            //driver.FindElement(By.Id("debitregistertype")).Click();

            //Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Registration_Type + "']")));
            //driver.FindElement(By.XPath("//*[@text='" + Registration_Type + "']")).Click();
            //End();

            //Next
            start(); methodnamefiningfunction("Clicking Next");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
            driver.FindElement(By.Id("btsubmit")).Click();
            End();

            //Next
            start(); methodnamefiningfunction("Clicking Next");
            Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmit")));
            driver.FindElement(By.Id("btsubmit")).Click();
            End();


            if (Payment == "Cash")
            {
                start(); methodnamefiningfunction("Clicking Cash");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Payment + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Payment + "']")).Click();
                End();

                scroll("down");

                //customer alert Number
                start(); methodnamefiningfunction("Entering customer Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etnewmob")));
                driver.FindElement(By.Id("etnewmob")).Clear();
                driver.FindElement(By.Id("etnewmob")).SendKeys(Customer_Alternate_No);
                End();

                scroll("halfdown");

                //Entering 
                start(); methodnamefiningfunction("Entering Tpin");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etcpin")));
                driver.FindElement(By.Id("etcpin")).Clear();
                driver.FindElement(By.Id("etcpin")).SendKeys(Confirm_TPIN);
                End();

                Thread.Sleep(2000);
                string Payable_Amount = driver.FindElement(By.Id("tvCusPolicy")).Text;

                if (Convert.ToSingle(Payable_Amount) > 50000.0)
                {

                    //Save
                    start(); methodnamefiningfunction("Clicking SAVE");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='PAY']")));
                    driver.FindElement(By.XPath("//*[@text='PAY']")).Click();
                    End();

                    //Yes
                    start(); methodnamefiningfunction("Clicking Yes");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='YES']")));
                    driver.FindElement(By.XPath("//*[@text='YES']")).Click();
                    End();

                }
                else
                {
                    //Save
                    start(); methodnamefiningfunction("Clicking SAVE");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='PAY']")));
                    driver.FindElement(By.XPath("//*[@text='PAY']")).Click();
                    End();
                }
            }

            if (Payment == "DD / Cheque")
            {
                //DD-Payment
                start(); methodnamefiningfunction("clicking DD-Payment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Payment + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Payment + "']")).Click();
                End();

                Thread.Sleep(1000);
                new TouchAction(driver).Press(530, 736).MoveTo(506, 1386).Release().Perform();

                start(); methodnamefiningfunction("clicking Instrument type");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Instrument_Type + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Instrument_Type + "']")).Click();
                End();

                string Payable_Amount = driver.FindElement(By.Id("tvCusPolicy")).Text;

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etInsAmount")));
                driver.FindElement(By.Id("etInsAmount")).SendKeys(Payable_Amount);

                //DD_Number
                start(); methodnamefiningfunction("Entering DD_Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etInsNumber")));
                driver.FindElement(By.Id("etInsNumber")).SendKeys(DD_Cheque_No);
                End();

                scroll("down");

                //Bank_Name
                start(); methodnamefiningfunction("Entering Bank_Name");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etInsBank")));
                driver.FindElement(By.Id("etInsBank")).SendKeys(Bank_Name);
                Thread.Sleep(800);

                new TouchAction(driver).Tap(114, 1062).Release().Perform();
                End();

                //Bank_Branch
                start(); methodnamefiningfunction("Entering Bank_Branch");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etBankBr")));
                driver.FindElement(By.Id("etBankBr")).SendKeys(Bank_Branch);
                End();

                scroll("down");

                //customer alert Number
                start(); methodnamefiningfunction("Entering customer Alternate Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etbanknNewMobileNo")));
                driver.FindElement(By.Id("etbanknNewMobileNo")).Clear();
                driver.FindElement(By.Id("etbanknNewMobileNo")).SendKeys(Customer_Alternate_No);
                End();

                //TPin
                start(); methodnamefiningfunction("Entering TPin");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etBankTpin")));
                driver.FindElement(By.Id("etBankTpin")).SendKeys(Confirm_TPIN);
                End();

                //int result = int.Parse(Payable_Amount);

                //SAVE
                start(); methodnamefiningfunction("Entering SAVE");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("paymentSave")));
                driver.FindElement(By.Id("paymentSave")).Click();
                Thread.Sleep(2000);
                End();


                if (Convert.ToSingle(Payable_Amount) > 50000.0)
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Yes");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='YES']")));
                    driver.FindElement(By.XPath("//*[@text='YES']")).Click();
                    End();
                }
                else
                {
                    //Yes
                    start(); methodnamefiningfunction("Entering Yes");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='YES']")));
                    driver.FindElement(By.XPath("//*[@text='YES']")).Click();
                    End();
                }

                
            }
            if (Payment == "Online Payment")
            {

                start(); methodnamefiningfunction("clicking DD-Payment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Payment + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Payment + "']")).Click();
                End();

                start(); methodnamefiningfunction("Entering customer Alternate Number");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etAlterMobile")));
                driver.FindElement(By.Id("etAlterMobile")).Clear();
                driver.FindElement(By.Id("etAlterMobile")).SendKeys(Alternate_Mobile_Number);
                End();


                start(); methodnamefiningfunction("Entering customer Alternate Email");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("etAlterEmail")));
                driver.FindElement(By.Id("etAlterEmail")).Clear();
                driver.FindElement(By.Id("etAlterEmail")).SendKeys(Alternate_Email_ID);
                End();

                start(); methodnamefiningfunction("Entering Bank_Branch");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btPay")));
                driver.FindElement(By.Id("btPay")).Click();
                End();
            }

            if (Payment == "SMS Link")
            {
                start(); methodnamefiningfunction("clicking DD-Payment");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Payment + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Payment + "']")).Click();
                End();

                start(); methodnamefiningfunction("Entering Bank_Branch");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("confirmBbut")));
                driver.FindElement(By.Id("confirmBbut")).Click();
                End();
            }

            //SUBMIT
            start(); methodnamefiningfunction("Entering SUBMIT");
            wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btsubmits")));
            driver.FindElement(By.Id("btsubmits")).Click();
            End();
        }
        public void Other_LifeAddress()
        {
            if (Proposer_Address_Same_As_Life_Assured == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Same Address");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("checkPAConfirm")));
                driver.FindElement(By.Id("checkPAConfirm")).Click();
                End();
            }
            else
            {

                //Proposer_DooNo
                start(); methodnamefiningfunction("Entering Comm_DooNo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtPAStreetName")));
                driver.FindElement(By.Id("edtPAStreetName")).SendKeys(Proposer_DoorNo);
                End();

                //Proposer_Street
                start(); methodnamefiningfunction("Entering Comm_DooNo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtPAStreetName2")));
                driver.FindElement(By.Id("edtPAStreetName2")).SendKeys(Proposer_Street);
                End();

                scroll("halfdown");

                //Proposer_Pincode              
                start(); methodnamefiningfunction("Entering Pincode");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edt_pincode_pa")));
                driver.FindElement(By.Id("edt_pincode_pa")).SendKeys(Proposer_Pincode);

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btn_Search_pa")));
                driver.FindElement(By.Id("btn_Search_pa")).Click();
                End();

                //Proposer_Area
                start(); methodnamefiningfunction("Entering Area");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edt_area_pa")));
                driver.FindElement(By.Id("edt_area_pa")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Proposer_Area + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Proposer_Area + "']")).Click();
                End();

                scroll("halfdown");
                scroll("halfdown");

            }
        }
        public void Proposal_Document()
        {
            //Prop_ID_Proof
            if (Prop_ID_Proof_Upload == "Yes")
            {
                start(); methodnamefiningfunction("Entering Photo");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proPhotoId")));
                driver.FindElement(By.Id("proPhotoId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Prop_ID_Proof + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Prop_ID_Proof + "']")).Click();

                if (Prop_ID_Proof == "Passport")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderIdProofPro")));
                    driver.FindElement(By.Id("dateCalenderIdProofPro")).Click();

                }
                else if (Prop_ID_Proof == "Driving License")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderIdProofPro")));
                    driver.FindElement(By.Id("dateCalenderIdProofPro")).Click();
                }

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("photoScanId")));
                driver.FindElement(By.Id("photoScanId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //Prop_ID_Proof
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();

                //SAVE
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();
            }

            //Prop_Address_Proof
            if (Prop_Address_Proof_Upload == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Address Proof");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proAddressProof")));
                driver.FindElement(By.Id("proAddressProof")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Prop_Address_Proof + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Prop_Address_Proof + "']")).Click();
                End();

                if (Prop_Address_Proof == "Passport" || Prop_Address_Proof == "Driving License")
                {
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderAddressProofPro")));
                    driver.FindElement(By.Id("dateCalenderAddressProofPro")).Click();
                }

                start(); methodnamefiningfunction("Clicking Idproof photo graph of Proposer");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("addressScanId")));
                driver.FindElement(By.Id("addressScanId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();

                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //Prop_ID_Proof
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();

                //SAVE
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();

            }
            //Prop_Address_Proof
            if (Prop_Income_Proof_Upload == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Income Proof");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proIncomeProof")));
                driver.FindElement(By.Id("proIncomeProof")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Prop_Income_Proof + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Prop_Income_Proof + "']")).Click();
                End();

                start(); methodnamefiningfunction("Clicking Income photo graph of Proposer");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("proincomeScanId")));
                driver.FindElement(By.Id("proincomeScanId")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text=' GALLERY ']")));
                driver.FindElement(By.XPath("//*[@text=' GALLERY ']")).Click();
                //
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.widget.RelativeLayout[@index='1']")));
                driver.FindElement(By.XPath("//android.widget.RelativeLayout[@index='1']")).Click();

                //Prop_Income_Proof
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//android.view.ViewGroup[@index='1']")));
                driver.FindElement(By.XPath("//android.view.ViewGroup[@index='1']")).Click();

                //SAVE
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("savebutton")));
                driver.FindElement(By.Id("savebutton")).Click();
                End();

                scroll("down");
            }
        }
        public void Other_details()
        {
            //others details
            //Any_form_of_racing_etc
            if (Any_form_of_racing_etc == "Yes")
            {
                start(); methodnamefiningfunction("Clicking Insurance Any_form_of_racing_etc");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioadvhobbiesyes")));
                driver.FindElement(By.Id("radioadvhobbiesyes")).Click();
                End();

                //Any_form_of_racing_etc-Provide details
                start(); methodnamefiningfunction("Clicking Any_form_of_racing_etc_provide_details");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtadvhobbiesYes")));
                driver.FindElement(By.Id("edtadvhobbiesYes")).SendKeys(Any_form_of_racing_etc_provide_details);
                End();

                scroll("halfdown");
            }
            else
            {
                start(); methodnamefiningfunction("Clicking Any_form_of_racing_etc");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("radioadvhobbiesno")));
                driver.FindElement(By.Id("radioadvhobbiesno")).Click();
                End();
            }

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

            scroll("halfdown");

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
                catch {
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
            
            string[] family_members = Name_of_Family_Member.Split(',');

            int[] intarr = new int[family_members.Length];

            for (int i = 0; i < intarr.Length; i++)
            {
                //adding family Details
                start(); methodnamefiningfunction("Clicking famil deatils");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("addFamMem")));
                driver.FindElement(By.Id("addFamMem")).Click();
                End();

                //Name_of_Family_Member
                start(); methodnamefiningfunction("Entering Name_of_Family_Member");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtNameofFamilyMem")));
                driver.FindElement(By.Id("edtNameofFamilyMem")).SendKeys(family_members[i]);
                End();

                //select relationship
                string[] Realtionship = Family_Details_Relationship.Split(',');

                start(); methodnamefiningfunction("Selecting Relationship");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("familyRelations")));
                driver.FindElement(By.Id("familyRelations")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + Realtionship[i] + "']")));
                driver.FindElement(By.XPath("//*[@text='" + Realtionship[i] + "']")).Click();
                End();

                //Entering Age 
                string[] age = Family_Details_Age.Split(',');

                start(); methodnamefiningfunction("Entering Age");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtAge")));
                driver.FindElement(By.Id("edtAge")).SendKeys(age[i]);
                End();

                string[] status = Family_Details_Status.Split(',');

                //status
                start(); methodnamefiningfunction("Selecting status");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("familyStatus")));
                driver.FindElement(By.Id("familyStatus")).Click();

                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + status[i] + "']")));
                driver.FindElement(By.XPath("//*[@text='" + status[i] + "']")).Click();
                End();

                if (status[i] == "Alive")
                {
                    //health status
                    string[] health_status = Family_Details_Health_Status.Split(',');

                    start(); methodnamefiningfunction("Entering Health Status");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("healthStatus")));
                    driver.FindElement(By.Id("healthStatus")).Click();

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//*[@text='" + health_status[i] + "']")));
                    driver.FindElement(By.XPath("//*[@text='" + health_status[i] + "']")).Click();

                    if (health_status[i] == "Adverse")
                    {
                        try
                        {
                            string[] health_status1 = Adverse_Reason.Split(',');
                            Wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtstatus")));
                            driver.FindElement(By.Id("edtstatus")).SendKeys(health_status1[i]);
                        }
                        catch { }
                        try
                        {
                            Wait2.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtstatus")));
                            driver.FindElement(By.Id("edtstatus")).SendKeys(Adverse_Reason);
                        }
                        catch { }
                    }
                    End();
                }
                else if (status[i] == "Death")
                {
                    start(); methodnamefiningfunction("Entering Health Status");
                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("dateCalenderdeath")));
                    driver.FindElement(By.Id("dateCalenderdeath")).Click();

                    Deathdate(Death_Date);

                    Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("edtDeathReason")));
                    driver.FindElement(By.Id("edtDeathReason")).SendKeys(Death_Reason);
                    End();
                }

                //ok
                start(); methodnamefiningfunction("Clicking ok");
                Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id("btnok")));
                driver.FindElement(By.Id("btnok")).Click();
                End();
            }
        }
    }
}

