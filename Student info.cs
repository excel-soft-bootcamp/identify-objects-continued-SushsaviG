using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class Student_info
    {
        private string id;
        private string name;
        private string marks;
        public string GetId() { return this.id; }
        public string GetName()
        {
            return this.name;
        }
        public string GetMarks()
        {
            return this.marks;
        }
        public void SetId(string value) { this.id = value; }
        public void SetName(string value) { this.name = value; }
        
    }
}
