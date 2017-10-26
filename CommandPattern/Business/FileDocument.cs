using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPattern.Business
{
    public class FileDocument
    {
        private string fileName;
        private StringBuilder fileContent;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        

        public StringBuilder FileContent
        {
            get { return fileContent; }
            set { fileContent = value; }
        }

        public FileDocument(string name) {
            this.fileName = name;
            this.fileContent = new StringBuilder();
        }

        public void OpenFile()
        {
            MessageBox.Show("File "+this.fileName+" is Open");
        }
        public void CloseFile()
        {
            MessageBox.Show("File " + this.fileName + " is Closed");
        }
        public void Write(StringBuilder content){
            this.fileContent = content;
            MessageBox.Show("New File Content:\n " + this.fileContent.ToString());
        }

    }
}
