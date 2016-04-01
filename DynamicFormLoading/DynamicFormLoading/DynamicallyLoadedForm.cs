using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicFormLoading
{
    public partial class DynamicallyLoadedForm : Form
    {
        public DynamicallyLoadedForm()
        {
            InitializeComponent();
        }

        public Type PassedFormObject { get; set; }

        private void DynamicallyLoadedForm_Load(object sender, EventArgs e)
        {
            var objectFromMainForm = Activator.CreateInstance(this.PassedFormObject);
            CreateFormElements((IFormObject)objectFromMainForm);
            
        }

        public Label CreateNewLabel(string elementName, int elementNumber)
        {
            var newLabel = new Label();
            var location = new Point(15, ((elementNumber) * 35));
            newLabel.Name = "lbl" + elementName;
            newLabel.Text = elementName;
            newLabel.Location = location;
            this.Controls.Add(newLabel);
            return newLabel;
        }

        public void CreateNewTextBox(string elementName, string elementType, int elementNumber)
        {
            var newTextBox = new TextBox();
            var location = new Point(150, ((elementNumber) * 35));
            newTextBox.Name = "txt" + elementName;
            newTextBox.Location = location;
            this.Controls.Add(newTextBox);
        }

        public void CreateNewCheckBox(string elementName, string elementType, int elementNumber, bool representedValue)
        {
            var newCheckBox = new RadioButton();
            Point location;
            if (representedValue) { location = new Point(150, ((elementNumber) * 35)); }
            else { location = new Point(200, ((elementNumber) * 35)); }
            newCheckBox.Name = "rdo" + elementName + "_" + representedValue.ToString();
            newCheckBox.Text = representedValue.ToString();
            newCheckBox.AutoSize = true;
            newCheckBox.Location = location;
            this.Controls.Add(newCheckBox);

        }

        public void CreateNewDateTime(string elementName, string elementType, int elementNumber)
        {
            var newDateTimePicker = new DateTimePicker();
            var location = new Point(150, ((elementNumber) * 35));
            newDateTimePicker.Name = "dtp" + elementName;
            newDateTimePicker.Location = location;
            this.Controls.Add(newDateTimePicker);
        }

        public void CreateNewButton(string buttonText, int position)
        {
            var newButton = new Button();
            var location = new Point((this.Width/2) - 40, ((position) * 35));
            newButton.Name = "btn" + buttonText;
            newButton.Text = buttonText;
            newButton.AutoSize = true;
            newButton.Location = location;
            this.Controls.Add(newButton);
        }

        public void CreateFormElements(IFormObject objectFromMainForm)
        {
            var reflectedObject = objectFromMainForm.GetProperties();
            List<string> elementNames = reflectedObject.PropertyNames;
            List<string> elementTypes = reflectedObject.PropertyTypes;
            int numberOfElements = objectFromMainForm.NumberOfProperties;
            
            for (int i = 0; i < elementNames.Count - 1; i++)
            {
                CreateNewLabel(elementNames[i], i + 1);
                switch (elementTypes[i])
                {
                    case "System.String":
                        CreateNewTextBox(elementNames[i], elementTypes[i], i + 1);
                        break;
                    case "System.Int32":
                        CreateNewTextBox(elementNames[i], elementTypes[i], i + 1);
                        break;
                    case "System.Boolean":
                        CreateNewCheckBox(elementNames[i], elementTypes[i], i + 1, true);
                        CreateNewCheckBox(elementNames[i], elementTypes[i], i + 1, false);
                        break;
                    case "System.DateTime":
                        CreateNewDateTime(elementNames[i], elementTypes[i], i + 1);
                        break;
                    default:
                        break;
                }
            }
            CreateNewButton("Add new " + objectFromMainForm.ToString(), elementNames.Count);
            this.Height += 30;
            this.Width += 30;
        }
    }
}
