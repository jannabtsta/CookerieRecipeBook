using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RecipeBookDL;
using RecipeBookModel;

namespace RecipeBookBL
{
    public class RecipeBL
    {
        RecipeDL recipedl = new RecipeDL();

        public List<RecipeModel> KareKareBL()
        {
            return recipedl.GetKareKare();
        }

        public List<RecipeModel> SinigangBL()
        {
            return recipedl.GetSinigang();
        }

        public List<RecipeModel> ChicharonBL()
        {
            return recipedl.GetChicharon();
        }

        public List<RecipeModel> ParesBL()
        {
            return recipedl.Getpares();
        }

        public List<RecipeModel> GotoBL()
        {
            return recipedl.Getgoto();
        }
    }
}
