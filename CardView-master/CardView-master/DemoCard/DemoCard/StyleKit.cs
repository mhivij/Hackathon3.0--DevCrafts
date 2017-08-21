using Xamarin.Forms;


namespace DemoCard.Styles
{
    //Globally initilization of style of controls
    public static class StyleKit
    {
        public static Color MediumGrey = Color.White;
        public static Color CardBorderColor = Color.White;
        public static Color LightTextColor = Color.White;

        public static Color BarBackgroundColor = Color.White;
        public static Color CardFooterBackgroundColor = Color.White;

        public static class Status
        {
            public static Color CompletedColor = Color.White;
            public static Color AlertColor = Color.White;
            public static Color UnresolvedColor = Color.White;
        }
        public class Icons
        {
            public static FileImageSource Alert = new FileImageSource() { File = "Alert.png" };
            public static FileImageSource Resume = new FileImageSource() { File = "Resume.png" };
            public static FileImageSource Completed = new FileImageSource() { File = "Completed.png" };
            public static FileImageSource Report = new FileImageSource() { File = "Report.png" };
            public static FileImageSource Unresolved = new FileImageSource() { File = "Unresolved.png" };
            public static FileImageSource Cog = new FileImageSource() { File = "Config.png" };
            public static FileImageSource SmallCalendar = new FileImageSource() { File = "Calendarmini.png" };
            public static FileImageSource SmallClock = new FileImageSource() { File = "Clockmini.png" };
            public static FileImageSource Shadow0240 = new FileImageSource() { File = "Shadow-0-2-4-0.png" };
            public static FileImageSource Share = new FileImageSource() { File = "Share.png" };

            public static FileImageSource TitleImageSource1 = new FileImageSource()  { File = "dishesfa.png" };
            public static FileImageSource TitleImageSource2 = new FileImageSource()  { File = "dishesfb.png" };
            public static FileImageSource TitleImageSource3 = new FileImageSource()  { File = "dishesfc.png" };
            public static FileImageSource TitleImageSource4 = new FileImageSource()  { File = "dishesfd.png" };
            public static FileImageSource TitleImageSource5 = new FileImageSource()  { File = "dishesfe.png" };
            public static FileImageSource TitleImageSource6 = new FileImageSource()  { File = "dishesff.png" };
            public static FileImageSource TitleImageSource7 = new FileImageSource()  { File = "dishesfg.png" };
            public static FileImageSource TitleImageSource8 = new FileImageSource()  { File = "dishesfh.png" };
            public static FileImageSource TitleImageSource9 = new FileImageSource()  { File = "dishesfi.png" };
            public static FileImageSource TitleImageSource10 = new FileImageSource() { File = "dishesfj.png" };

            public static string FirstTabTitleImage = "deal.png";
            public static string SecondTabTitleImage = "scan.png";
            public static string ThirdTabTitleImage = "notes.png";
            public static string FourthTabTitleImage = "setting.png";

            public static string ErrorIcon = "error.png";
            public static string SuccessIcon = "success.png";
        }
    }
}
