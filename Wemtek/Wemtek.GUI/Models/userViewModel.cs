using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Wemtek.Domain.Entities;


namespace Wemtek.GUI.Models
{
    public partial class userViewModel 
    {
        public userViewModel() 
        {
            this.deals = new List<dealViewModel>();
            this.meetingdetails = new List<meetingdetailViewModel>();
            this.members = new List<memberViewModel>();
            this.projectreviews = new List<projectreviewViewModel>();
            this.skills = new List<skillViewModel>();
            this.tasks = new List<taskViewModel>();
        }

        public int idUser { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserRole_RoleId { get; set; }
        public Nullable<int> company_Id { get; set; }
        public Nullable<int> templateId_idTemplate { get; set; }
        public virtual companyViewModel company { get; set; }
        public IEnumerable<SelectListItem> companies { get; set; }
        public virtual ICollection<dealViewModel> deals { get; set; }
        public virtual ICollection<meetingdetailViewModel> meetingdetails { get; set; }
        public virtual ICollection<memberViewModel> members { get; set; }
        public virtual ICollection<projectreviewViewModel> projectreviews { get; set; }
        public virtual roleViewModel role { get; set; }
        public virtual ICollection<skillViewModel> skills { get; set; }
        public virtual ICollection<taskViewModel> tasks { get; set; }
        public virtual templateViewModel template { get; set; }
    }
}
