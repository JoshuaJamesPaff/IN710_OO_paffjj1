﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Art_Database_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Artist> artists;
        public List<Painting> paintings;

        private void Form1_Load(object sender, EventArgs e)
        {
            artists = new List<Artist>();
            artists.Add(new Artist { Country = "France", FirstName = "Camille", LastName = "Pissarro", YearOfBirth = 1830, YearOfDeath = 1903 });
            artists.Add(new Artist { Country = "France", FirstName = "Claude", LastName = "Monet", YearOfBirth = 1840, YearOfDeath = 1926 });
            artists.Add(new Artist { Country = "England", FirstName = "John", LastName = "Constable", YearOfBirth = 1776, YearOfDeath = 1837 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Jan", LastName = "Vermeer", YearOfBirth = 1632, YearOfDeath = 1675 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sanzio", LastName = "Raphael", YearOfBirth = 1483, YearOfDeath = 1520 });
            artists.Add(new Artist { Country = "Spain", FirstName = "Pablo", LastName = "Picasso", YearOfBirth = 1881, YearOfDeath = 1973 });
            artists.Add(new Artist { Country = "Norway", FirstName = "Edvard", LastName = "Munch", YearOfBirth = 1863, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Leonardo", LastName = "da Vinci", YearOfBirth = 1452, YearOfDeath = 1519 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sandro", LastName = "Botticelli", YearOfBirth = 1445, YearOfDeath = 1510 });
            artists.Add(new Artist { Country = "France", FirstName = "Henri", LastName = "Matisse", YearOfBirth = 1869, YearOfDeath = 1954 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Piet", LastName = "Mondrian", YearOfBirth = 1872, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "United States", FirstName = "Jackson", LastName = "Pollock", YearOfBirth = 1912, YearOfDeath = 1956 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Vincent", LastName = "van Gogh", YearOfBirth = 1853, YearOfDeath = 1890 });

            paintings = new List<Painting>();
            paintings.Add(new Painting { Artist = "van Gogh", Title = "The Starry Night", Method = "Oil on canvas", Year = 1889, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "van Gogh", Title = "Village Street in Auvers ", Method = "Oil on canvas", Year = 1890, Width = 73, Height = 92 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Gelee Blanche", Method = "Oil on canvas", Year = 1873, Width = 65, Height = 93 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Village Path", Method = "Oil on canvas", Year = 1875, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Fishing Boats Leaving the Harbor, Le Havre ", Method = "Oil on canvas", Year = 1874, Width = 60, Height = 101 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Water Lilies ", Method = "Oil on canvas", Year = 1906, Width = 88, Height = 93 });
            paintings.Add(new Painting { Artist = "Constable", Title = "The Leaping Horse", Method = "Oil on canvas", Year = 1825, Width = 142, Height = 187 });
            paintings.Add(new Painting { Artist = "Vermeer", Title = "Girl with a Pearl Earring", Method = "Oil on canvas", Year = 1665, Width = 45, Height = 40 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "Madonna dell Granduca ", Method = "Oil on wood", Year = 1505, Width = 84, Height = 55 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "St. George Fighting the Dragon ", Method = "Oil on wood", Year = 1825, Width = 28, Height = 21 });
            paintings.Add(new Painting { Artist = "Munch", Title = "The Scream", Method = "Tempera on paper", Year = 1893, Width = 91, Height = 74 });
            paintings.Add(new Painting { Artist = "da Vinci", Title = "The Last Supper", Method = "Tempera on plaster", Year = 1498, Width = 460, Height = 880 });
            paintings.Add(new Painting { Artist = "Botticelli", Title = "The Birth of Venus", Method = "Tempera on canvas", Year = 1485, Width = 173, Height = 280 });
            paintings.Add(new Painting { Artist = "Matisse", Title = "La Musique", Method = "Oil on canvas", Year = 1939, Width = 115, Height = 115 });
            paintings.Add(new Painting { Artist = "Mondrian", Title = "Composition with Red, Yellow and Blue", Method = "Oil on canvas", Year = 1821, Width = 40, Height = 35 });
            paintings.Add(new Painting { Artist = "Pollock", Title = "The Key", Method = "Oil on canvas", Year = 1946, Width = 84, Height = 213 });
            paintings.Add(new Painting { Artist = "Picasso", Title = "The Three Musicians", Method = "Oil on canvas", Year = 1921, Width = 200, Height = 222 });



        }

        //------------------------------------------------------
        // btnAllPaintings
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Painting p in paintings)
            {
                listBox1.Items.Add(p.ToString());
            }
        }


        //------------------------------------------------------
        // btnArtistsFromItaly
        //------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var italianArtists = from artist in artists where String.Equals(artist.Country, "Italy") select artist.ToString();

            foreach (string artist in italianArtists)
            {
                listBox1.Items.Add(artist);
            }
        }

        //------------------------------------------------------
        // btnBefore1800
        //------------------------------------------------------
        private void btnBefore1800_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var before1800 = from painting in paintings where painting.Year < 1800 select painting.ToString();

            foreach (string painting in before1800)
            {
                listBox1.Items.Add(painting);
            }
        }

        //------------------------------------------------------
        // btnOldest
        //------------------------------------------------------
        private void btnOldest_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var oldest = from painting in paintings where painting.Year == paintings.Min(p => p.Year) select painting.ToString();

            foreach (string painting in oldest)
            {
                listBox1.Items.Add(painting);
            }
           
        }

        //------------------------------------------------------
        // byThisArtist
        //------------------------------------------------------
        private void buttonPaintedBy_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string artist = textBoxArtistInput.Text;

            var sameArtist = from painting in paintings where String.Equals(painting.Artist, artist) select painting.ToString();

            foreach (string painting in sameArtist)
            {
                listBox1.Items.Add(painting);
            }

        }

        //------------------------------------------------------
        // btnNbyCountry
        //------------------------------------------------------
        private void btnNbyCountry_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // joins paintings and artists selecting artists country
            var paintingsWithCountry = from painting in paintings
                                  join artist in artists
                                  on painting.Artist equals artist.LastName
                                  select new {painting, artist.Country};

            //groups the joined table by country
            var groupByCountry = from p in paintingsWithCountry
                                 group p by p.Country;

            //unpacks the count of paintings and country name for each country group
            foreach (var country in groupByCountry)
            {
                String countryName = country.Key;
                int paintingCount = country.Count();

                string painting = " paintings from ";
                if (paintingCount > 0 && paintingCount < 2) painting = " painting from ";

                listBox1.Items.Add(paintingCount + painting + countryName);
            }
            
        }

        //------------------------------------------------------
        // btnArtistGroupedByCountry
        //------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //groups artists by their country
            var countryArtists = from artist in artists
                                 group artist by artist.Country;

            //loops thru each country and prints out each artist
            foreach (var country in countryArtists)
            {
                //prints country
                String countryName = country.Key;
                listBox1.Items.Add(countryName + ":");

                //prints each artist
                foreach (Artist a in country)
                {
                    listBox1.Items.Add("\t" + a.FirstName + " " + a.LastName);
                }

                listBox1.Items.Add("-------------------------------------------------");
            }
        }

        //------------------------------------------------------
        // btnDutchPainters
        //------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //gets dutch artists
            var dutchArtists = from artist in artists
                                 where String.Equals(artist.Country, "Netherlands")
                                 select artist;

            // joins paintings to dutch artists to get dutch paintings
            var dutchPaintings = from painting in paintings
                                       join artist in dutchArtists
                                       on painting.Artist equals artist.LastName
                                       select painting;

            //loops thru each painting to print
            foreach (Painting painting in dutchPaintings)
            {
                listBox1.Items.Add(painting.ToString());
            }      
        }

        //------------------------------------------------------
        // btnJoinTables
        //------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // joins paintings and artists selecting artists country
            var paintingsWithCountry = from painting in paintings
                                       join artist in artists
                                       on painting.Artist equals artist.LastName
                                       select new { artist.FirstName, artist.LastName, artist.Country, painting.Title };
            //loops thru each painting to print
            foreach (var p in paintingsWithCountry)
            {
                listBox1.Items.Add(p.FirstName + " " + p.LastName + "\t" + p.Country + "\t" + p.Title);
            }  
        }

        //------------------------------------------------------
        // btnFrenchOrItalian
        //------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //gets French Or Italian artists
            var frenchOrItalian = from artist in artists
                               where (String.Equals(artist.Country, "Italy") || String.Equals(artist.Country, "France"))
                               select artist;

            // joins paintings to dutch artists to get dutch paintings
            var frenchItalianPaintings = from painting in paintings
                                 join artist in frenchOrItalian
                                 on painting.Artist equals artist.LastName
                                 select painting;

            //loops thru each painting to print
            foreach (Painting painting in frenchItalianPaintings)
            {
                listBox1.Items.Add(painting.ToString());
            }      
        }

 
    }
}
