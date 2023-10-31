using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Assignment1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                // Set the default image when the page loads
                DogImage.ImageUrl = "Images/default.jpeg";
            }
        }

        protected void ShowCost(object sender, EventArgs e)
        {
            // Replace this with your logic to calculate and display the cost
            // Here, we're just displaying a placeholder message
            string selectedItem = Dogs.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "German shepherd")
            {

                cost = "100000";

            }

            else if (selectedItem == "Poodle")
            {

                cost = "150000";
            }

            else if (selectedItem == "Maltese")
            {

                cost = "200000";
            }
            else if (selectedItem == "chowchow")
            {

                cost = "80000";
            }

            string Item = Dogs.SelectedItem.Text;

            Cost.Text = $"Cost of {Item}: {cost}";

        }

        protected void Dogss(object sender, EventArgs e)
        {
            // When an item is selected, update the image accordingly
            string selectedItem = Dogs.SelectedValue;
            string cost = string.Empty;
            if (selectedItem == "German shepherd")
            {
                DogImage.ImageUrl = $"Images/German_Shepherd.jpeg";


            }

            else if (selectedItem == "Poodle")
            {
                DogImage.ImageUrl = $"Images/Poodle.jpeg";

            }

            else if (selectedItem == "Maltese")
            {
                DogImage.ImageUrl = $"Images/Maltese.jpeg";

            }
            else if (selectedItem == "chowchow")
            {
                DogImage.ImageUrl = $"Images/chowchow.jpeg";

            }
            else
            {

                DogImage.ImageUrl = $"Images/{"Images/default.jpeg"}";
            }
        }
    }


}