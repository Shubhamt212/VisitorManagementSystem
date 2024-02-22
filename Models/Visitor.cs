using Microsoft.EntityFrameworkCore;

namespace VisitorManagementSystem.Models
{
    public class Visitor
    {
        public int VisitorId { get; set; }//primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get {  return FirstName + "" + LastName; } }
        public string Address { get; set; }
        public int Number {  get; set; }
        public string Gender { get; set; }
        public string Remarks { get; set; }
       
        public int ManagerId { get; set; } //foreign key

        public Manager? Manager { get; set; }
        


    }
}
