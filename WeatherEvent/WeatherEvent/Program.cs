namespace WeatherEvent
{
    internal class Program
    {
        public class Weather
        {
            public int temperature { get; set; }
            // public string condition { get; set; }

            public delegate void WeatherChange(Weather erth, int temp);
            public event WeatherChange OnChange;
            public void ChangeingWeather(int temr)
            {
                this.temperature = temr;

                if (OnChange != null)
                {
                    OnChange(this, temr);
                }
            }

        }
        static void Main(string[] args)
        {
          
            Weather weather=new Weather();
            weather.OnChange += Weather_OnChange;
            weather.ChangeingWeather(23);
            weather.ChangeingWeather(10);
            weather.ChangeingWeather(30);
      
        }
        private static void Weather_OnChange(Weather erth, int temp)
        {
            if (temp < 17)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The Weather Today is Rainy and Cold");
            }
            else if (temp > 17 && temp < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Weather Today is Cloudy and No Rain");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Weather Today is Hot and Melt");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}