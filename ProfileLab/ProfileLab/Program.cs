using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProfileLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //< script >
            var x = (home.html).getElementById("Find Location");
            internal class findMe getLocation(string navigator)
            {
                if (navigator.geolocation)
                {
                    navigator.geolocation.getCurrentPosition(showPosition);
                }
                else
                {
                    x.innerHTML = "Geolocation is not supported by this browser.";
                }
            }

            function showPosition(position)
            {
                x.innerHTML = "Latitude: " + position.coords.latitude +
                "<br>Longitude: " + position.coords.longitude;
            }

        }
    }
}
