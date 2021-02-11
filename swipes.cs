using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;

namespace SLIC_Astra_Proposal
{
    class swipes
    {
        AppiumDriver<AndroidElement> driver;
        public swipes(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public void swipe(string Direction)
        {
            //int height = driver.Manage().Window.Size.Height;
            //int width = driver.Manage().Window.Size.Width; //720

            var size = driver.Manage().Window.Size;

            //Left to Right Swipe
            int startxx = (int)(size.Width * 0.90);
            int endxx = (int)(size.Width * 0.10);
            int startyy = (int)(size.Height / 2);

            //full bottom to top swipe(down)
            int startyyyy = (int)(size.Height * 0.65);
            int endyyyy = (int)(size.Height * 0.20);
            int startxxxx = size.Width / 2;

            //half down
            int startx12 = size.Width / 2;
            int starty112 = (int)(size.Height * 0.50);
            int endy112 = (int)(size.Height * 0.20);


            //right to left
            int startx = (int)(size.Width * 0.70);
            int endx = (int)(size.Width * 0.30);
            int starty = size.Height / 2;

            if (Direction == "down")
            {
                new TouchAction(driver).Press(startxxxx, startyyyy).Wait(700).MoveTo(startxxxx, endyyyy).Release().Perform();
                Thread.Sleep(1000);
            }
            //else if(Direction == "up")
            //{
            //    driver.Swipe(Convert.ToInt32(startx1), Convert.ToInt32(endy11), Convert.ToInt32(startx1), Convert.ToInt32(starty11), 3000);
            //}
            else if (Direction == "halfdown")
            {
                new TouchAction(driver).Press(startx12, starty112).Wait(700).MoveTo(startx12, endy112).Release().Perform();
            }
            //else if (Direction == "halfup")
            //{
            //    driver.Swipe(Convert.ToInt32(startx12), Convert.ToInt32(endy112), Convert.ToInt32(startx12), Convert.ToInt32(starty112), 3000);
            //}
            //else if (Direction == "dobhalfup")
            //{
            //    driver.Swipe(Startx, Starty, Startx, Endy, 3000);
            //}
            else if (Direction == "LeftSwipe")
            {
                Thread.Sleep(1000);
                new TouchAction(driver).Press(startx, starty).Wait(700).MoveTo(endx, starty).Release().Perform();

            }
            else if (Direction == "RightSwipe")
            {
                Thread.Sleep(1000);
                new TouchAction(driver).Press(endx, starty).Wait(700).MoveTo(startx, starty).Release().Perform();

            }

        }
    }
}
