using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBookModel;

namespace RecipeBookDL
{
    public class RecipeDL
    {
        public List<RecipeModel> karekare = new List<RecipeModel>();
        public List<RecipeModel> sinigang = new List<RecipeModel>(); 
        public List<RecipeModel> Chicharon = new List<RecipeModel>();
        public List<RecipeModel> pares = new List<RecipeModel>();
        public List<RecipeModel> agoto = new List<RecipeModel>();





        public RecipeDL()
        {
            StoredRecipe();
            GetKareKare();
        }
        public void StoredRecipe()
        {

            RecipeModel recipe1 = new RecipeModel
            {
                title = "KareKare",
                ingredients = "Boneless beef shank, Sitaw, Eggplant, Bok Choy",
                ingredients1 = "PeanutButter, Onion, Garlic, Annato Powder, Bagoong Alamang",
                procedure = "1.Boil water in pot, then put in the Beef followed by onion then simmer until tender",
                procedure1 = "2.Once meat is tender, add peanuts, liquified Annato Powder and simmer for 5-7mins.",
                procedure2 = "3.On a separate pan, saute the garlic, eggplant, and sitaw and cook for 5 minutes",
                procedure3 = "4.Transfer this to the large pot, then add salt and pepper to taste"

            };
            karekare.Add(recipe1);

            RecipeModel recipe2 = new RecipeModel
            {
                title = "Sinigang",
                ingredients = "Pork, Eggplant, Radish, Tomatoes, Onion, Fish Sauce",
                ingredients1 = "Kangkong,Okra,Tamarind base(mix),Gabi, sitaw, Green Peppers",
                procedure = "1.In a pot, combine the pork, tamarind base, and water. Bring to a boil.",
                procedure1 = "2.Add the vegetables",
                procedure2 = "3.Simmer until the pork is tender and the vegetables are cooked.",
                procedure3 = "4.Season with fish sauce and ground black pepper to taste"
            };
            sinigang.Add(recipe2);

            

            RecipeModel recipe3 = new RecipeModel
            {
                title = "Chicharon Bulaklak ",
                ingredients = "Pig Mesentery, Salt, Onion & Garlic Powder",
                ingredients1 = "Basil Leaves, Powdered Pepper, Canola Oil",
                procedure = "1.Wash the pig intestine thoroughly (4x), then Cut/divide the intestine into 4in. pcs.",
                procedure1 = "2.Mix the rest of ingredients in a large pot and season according to your liking.",
                procedure2 = "3.Simmer until the pork is tender and the vegetables are cooked.",
                procedure3 = "4.Add the intestine and start cooking. Boil the intestine until soft",
                procedure4 = "5.When done boiling, drain the water, tap dry, and let it cool.",
                procedure5 = "Refrigerate the intestine in a zip lock bag. After this, Deep-fre the chilled intestine"

            };
            Chicharon.Add(recipe3);

            RecipeModel recipe4 = new RecipeModel
            {
                title = "Beef Pares",
                ingredients = "Beef Brisket, Garlic, Ginger, Onions, Soy Sauce",
                ingredients1 = "Star Anise, Beef Cubes, Toasted Garlic and Chopped Spring onion",
                procedure = "1.Saute garlic, ginger, and onions until browned, then Stir in the beef and saute until browned.",
                procedure1 = "2.Add water to cover the beef, along with soy sauce, sugar, ginger, and star anise.",
                procedure2 = "3.Simmer until the meat is tender.",
                procedure3 = "4.Garnish with toasted garlic bits and chopped spring onions, serve with beef broth and garlic rice",

            };
            pares.Add(recipe4);

            RecipeModel recipe5 = new RecipeModel
            {
                title = "Arroz Caldo",
                ingredients = "Uncooked Rize, Semi Grind Chicken, Onion, Garlic, Ginger",
                ingredients1 = "Chicken Bouillon Cube, Fish Sauce, Boiled Egg, Toasted Garlic",
                procedure = "1.Sauté garlic, onion, and ginger in a pot until fragrant then.",
                procedure1 = "2.Add the chicken and stir in fish sauce. Pour in water and add the uncooked rice",
                procedure2 = "3.Bring to boild and simmer until rice is cooked and thickens.",
                procedure3 = "4.Add seasoning with fish sauce, serve hot and topped egg and toasted garlic. ",

            };
            agoto.Add(recipe5);
        }

        public List<RecipeModel> GetKareKare()
        {
            return karekare;
        }

        public List<RecipeModel> GetSinigang()
        {
            return sinigang;
        }

        public List<RecipeModel> GetChicharon()
        {
            return Chicharon;
        }

        public List<RecipeModel> Getpares()
        {
            return pares;
        }

        public List<RecipeModel> Getgoto()
        {
            return agoto;
        }


        //RecipeModel recipe3 = new RecipeModel
        //{
        //title = "",
        //ingredients = "",
        //ingredients1 = "",
        //procedure = "",
        //procedure1 = "",
        //procedure2 = "",
        //procedure3 = "",

        //};
        //sinigang.Add(recipe3);

    }
}
