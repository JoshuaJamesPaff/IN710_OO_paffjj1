using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_DB___Joshua_Paff
{
    public partial class Form1 : Form
    {
        //creates dictionary object and sample movies
        Dictionary<int, Movie> movieTable = new Dictionary<int, Movie>();
        Movie movie1 = new Movie(2000, "A Beautiful Mind", "Ron Howard");
        Movie movie2 = new Movie(2003, "LOTR: Return of the King", "Peter Jackson");
        Movie movie3 = new Movie(2006, "The Departed", "Martin Scorsese");
        

        public Form1()
        {
            InitializeComponent();

            movieTable.Add(movie1.Year, movie1);
            movieTable.Add(movie2.Year, movie2);
            movieTable.Add(movie3.Year, movie3);
            
        }

        // adds movie to dictionary with data from textbox
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            //gets data from textboxes
            String year = textBoxAddYear.Text;
            String title = textBoxAddTitle.Text;
            String director = textBoxAddDirector.Text;

            //if data is legit - adds to movie object then sends to dictionary
            if ((year != "") || (title != "") || (director != ""))
            {
                Movie newMovie = new Movie(Int32.Parse(year), title, director);
                movieTable.Add(Int32.Parse(year), newMovie);
            }
            else
            {
                MessageBox.Show("Please check input data");
            }
            
        }

        //deletes a movie based on input of its year
        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            int year = Int32.Parse(textBoxDeleteYear.Text);
            if (movieTable.ContainsKey(year))
            {
                movieTable.Remove(year);
            }

        }

        //prints all movies in the dictionary
        private void buttonPrintAll_Click(object sender, EventArgs e)
        {
            listBoxMovies.ResetText();
            foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
            {
                listBoxMovies.Items.Add("-------------------------");
                listBoxMovies.Items.Add(currentMovie.Value.ToString());

            }

        }
        // searches movieTable by year, taking input from a text box and dispaying results in a listbox
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxMovies.ResetText();
            int year = Int32.Parse(textBoxSearchYear.Text);
            if (movieTable.ContainsKey(year))
            {
                Movie searchedMovie = movieTable[year];
                listBoxMovies.Items.Add(searchedMovie.ToString());

            }
            else
            {
                MessageBox.Show("Movie from " + year + " not found.");
            }
        }
    }
}
