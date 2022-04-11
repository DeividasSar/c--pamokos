using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Topic_11_Aircrafts_project.Repositories
{
    public class CountryRepository
    {
        private List<Country> countries { get; set; }

        public CountryRepository ()
        {
            countries = new List<Country>();

            countries.Add(new Country(1, "LT", "Lithuania", "Europe", true));
            countries.Add(new Country(2, "KR", "Republic of South Korea", "Asia", false));
            countries.Add(new Country(3, "PL", "Poland", "Europe", true));
            countries.Add(new Country(4, "DE", "Germany", "Europe", true));
            countries.Add(new Country(5, "US", "USA", "North America", false));
            countries.Add(new Country(6, "AD", "Andorra", "Europe", false));
            countries.Add(new Country(7, "AE", "United Arab Emirates", "Asia", false));
            countries.Add(new Country(8, "AF", "Afghanistan", "Asia", false));
            countries.Add(new Country(9, "AG", "Antigua and Barbuda", "Central America", false));
            countries.Add(new Country(10, "AI", "Anguilla", "North America", false));
            countries.Add(new Country(11, "AL", "Albania", "Europe", false));
            countries.Add(new Country(12, "AM", "Armenia", "Asia", false));
            countries.Add(new Country(13, "AN", "Netherlands Antilles", "North America", false));
            countries.Add(new Country(14, "AR", "Argentina", "South America", false));
            countries.Add(new Country(15, "AS", "American Samoa", "Australia/Oceania", false));
            countries.Add(new Country(16, "AT", "Austria", "Europe", true));
            countries.Add(new Country(17, "ZW", "Zimbabwe", "Africa", false));
            countries.Add(new Country(18, "ZR", "Zaire", "Africa", false));
            countries.Add(new Country(19, "ZM", "Zambia", "Africa", false));
            countries.Add(new Country(20, "BA", "Bosnia and Herzegovina", "Europe", false));
            countries.Add(new Country(21, "YU", "Yugoslavia", "Europe", false));
            countries.Add(new Country(22, "UA", "Ukraine", "Europe", false));
            countries.Add(new Country(23, "WS", "Samoa", "Australia/Oceania", false));
            countries.Add(new Country(24, "WF", "Wallis and Futuna Islands", "Australia/Oceania", false));
            countries.Add(new Country(25, "VU", "Vanuatu", "Australia/Oceania", false));
            countries.Add(new Country(26, "VN", "Vietnam", "Asia", false));
            countries.Add(new Country(27, "VI", "Virgin Islands (USA)", "North America", false));
            countries.Add(new Country(28, "VG", "Virgin Islands (British)", "North America", false));
            countries.Add(new Country(29, "VE", "Venezuela", "South America", false));
            countries.Add(new Country(30, "VC", "Saint Vincent & Grenadines", "Central America", false));
            countries.Add(new Country(31, "UZ", "Uzbekistan", "Asia", false));
            countries.Add(new Country(32, "UY", "Uruguay", "South America", false));
            countries.Add(new Country(36, "UG", "Uganda", "Africa", false));
            countries.Add(new Country(34, "UM", "USA Minor Outlying Islands", "North America", false));
            countries.Add(new Country(35, "UK", "United Kingdom", "Europe", true));
            countries.Add(new Country(37, "UA", "Ukraine", "Europe", false));
            countries.Add(new Country(38, "TZ", "Tanzania", "Africa", false));
            countries.Add(new Country(39, "TW", "Taiwan", "Asia", false));
            countries.Add(new Country(40, "TV", "Tuvalu", "Australia/Oceania", false));
            countries.Add(new Country(41, "TT", "Trinidad and Tobago", "Central America", false));
            countries.Add(new Country(42, "TR", "Turkey", "Asia", false));
            countries.Add(new Country(43, "TO", "Tonga", "Australia/Oceania", false));
            countries.Add(new Country(44, "TN", "Tunisia", "Africa", false));
            countries.Add(new Country(45, "TM", "Turkmenistan", "Asia", false));
            countries.Add(new Country(219, "GL", "Greenland", "North America", false));
            countries.Add(new Country(220, "GI", "Gibraltar", "Europe", false));
            countries.Add(new Country(221, "GH", "Ghana", "Africa", false));
            countries.Add(new Country(222, "GF", "French Guyana", "South America", false));
            countries.Add(new Country(231, "BM", "Bermuda", "North America", false));
            countries.Add(new Country(233, "SD", "Sudan", "Africa", false));
            countries.Add(new Country(234, "ME", "Montenegro", "Europe", false));
            countries.Add(new Country(225, "BA", "Bosnia and Herzegovina", "Europe", false));
            countries.Add(new Country(246, "SS", "South Sudan", "Africa", false));
            countries.Add(new Country(247, "AO", "Angola", "Africa", false));
            countries.Add(new Country(255, "CI", "Cote d Ivoire", "Africa", false));
            countries.Add(new Country(244, "SV", "El Salvador", "Central America", false));
            countries.Add(new Country(245, "BO", "Bolivia", "South America", false));
            countries.Add(new Country(256, "PY", "Paraguay", "South America", false));
        }
        public List<Country> Retrieve()
        {
            return countries;
        }

        public Country RetrieveById(int id)
        {
            return countries.SingleOrDefault(x => x.Id == id);
        }
    }
}
