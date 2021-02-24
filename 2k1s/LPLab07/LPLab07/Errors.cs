using System;
using System.Collections.Generic;
using System.Text;

namespace LPLab07
{
    class ControlElementException : Exception
    {
        private string exceptionMessage = "Unknown ControlElement exception.";
        new public string Message
        {
            get
            {
                return exceptionMessage;
            }
        }

        public ControlElementException(string msg) : base("")
        {
            SetMessage(msg);
        }

        public void SetMessage(string msg)
        {
            exceptionMessage = "Control Element Exception: ";
            exceptionMessage += msg;
        }

        public void Display()
        {
            Console.WriteLine(Message);
            Console.WriteLine($"Error source: {this.Source}");
            Console.WriteLine($"Exception was in method: {this.TargetSite}");
        }
    }

    class ParameterControlElementException : ControlElementException
    {
        public ParameterControlElementException(string msg) : base(msg) { }
    }

    sealed class CoordsParameterControlElementException : ParameterControlElementException
    {
        public CoordsParameterControlElementException(int invalidX, int invalidY) : base ("")
        {
            SetMessage($"Coords are invalid. Used coords are X = {invalidX}, Y = {invalidY}.");
        }
    }

    sealed class WidthParameterControlElementException : ParameterControlElementException
    { 
        public WidthParameterControlElementException(int invalidWidth) : base("")
        {
            SetMessage($"Width parameter is invalid. Width = {invalidWidth}.");
        }
    }

    sealed class RadiusParameterControlElementException : ParameterControlElementException
    {
        public RadiusParameterControlElementException(int invalidRad) : base("")
        {
            SetMessage($"Radius parameter is invalid. Radius = {invalidRad}.");
        }
    }
}
