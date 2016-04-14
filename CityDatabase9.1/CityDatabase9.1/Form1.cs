using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityDatabase9._1
{
    public partial class Form1 : Form
    {
        private List<City> cities;

        public Func<String, City, bool> IsSameCountry = (search, city) => (search == city.CountryName);
        public Func<City, int> multiplyPop = (city) => (city.Population*3);

        public Form1()
        {
            InitializeComponent();
   
            SetData();
            multiplyPopulation();
        }

        public void SetData()
        {
            cities = new List<City>();
            cities.Add(new City("Whangarei", "New Zealand", 50000));
            cities.Add(new City("Auckland", "New Zealand", 1300000));
            cities.Add(new City("Hamilton", "New Zealand", 200000));
            cities.Add(new City("Wellington", "New Zealand", 400000));
            cities.Add(new City("Christchurch", "New Zealand", 400000));
            cities.Add(new City("Timaru", "New Zealand", 100000));
            cities.Add(new City("Queenstown", "New Zealand", 30000));
            cities.Add(new City("Dunedin", "New Zealand", 200000));
            cities.Add(new City("Invercargill", "New Zealand", 100000));
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxCities.Items.Clear();

            List<City> searchedList = new List<City>(); 
            foreach (City city in cities) if (IsSameCountry(textBoxSearch.Text, city)) searchedList.Add(city);
            foreach (City city in searchedList) listBoxCities.Items.Add(city.toString());
            
        }

        public void multiplyPopulation()
        {
            foreach (City city in cities) multiplyPop(city);
            foreach (City city in cities) listBoxCities.Items.Add(city.toString());
        }


    }
}
