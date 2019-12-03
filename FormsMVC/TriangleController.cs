using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMVC
{
    public class TriangleController
    {
        FormMain view;
        TriangleModel model;

        private string validationError;

        public TriangleController()
        {
            view = new FormMain(this);
        }

        public delegate void ValidationErrorHandler(string errors);

        public event ValidationErrorHandler OnError;

        public void Index()
        {
            Application.Run(view);
        }

        public bool Create(string a, string b, string c)
        { 
            if (Validate(a, b, c))
            {
                model = new TriangleModel(a, b, c);
                return true;
            }

            return false;
        }

        public void Show()
        {
            if (model != null)
            {
                view.TriangleShow(model);
            }
            else
            {
                OnError?.Invoke("No triangle");
            }
        }

        public bool Validate(string a, string b, string c)
        {
            bool isValid = true;
            validationError = "";
            double aVal, bVal, cVal;
            if (!Double.TryParse(a.Replace('.',','), out aVal)) 
            {
                validationError += "Incorrect A value!\n";
                isValid = false;
            }
            if (!Double.TryParse(b.Replace('.', ','), out bVal))
            {
                validationError += "Incorrect B value!\n";
                isValid = false;
            }
            if (!Double.TryParse(c.Replace('.', ','), out cVal))
            {
                validationError += "Incorrect C value!\n";
                isValid = false;
            }

            if (validationError != "")
            {
                OnError?.Invoke(validationError);
            }

            return isValid;
        }
    }
}
