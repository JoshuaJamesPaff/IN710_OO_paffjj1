using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace DogSelectorMVC.Models
{
    //enums for attributes
    public enum EScale { NoSelection, Low, Medium, High }
    public enum ELength { NoSelection, Short, Medium, Long }
    public enum ESize { NoSelection, Miniature, Small, Medium, Large, Giant }

    public class Dog
    {
        //name
        public String BreedName { get; set; }
        public String DisplayName { get; set; }

        //image location
        public String ImageName { get; set; }

        //attributes
        public EScale ActivityLevel { get; set; }
        public ELength Coatlength { get; set; }
        public bool Drools { get; set; }
        public bool GoodWithChildren { get; set; }
        public EScale GroomingLevel { get; set; }
        public EScale IntelligenceLevel { get; set; }
        public EScale SheddingLevel { get; set; }
        public ESize Size { get; set; }

        
    }
}