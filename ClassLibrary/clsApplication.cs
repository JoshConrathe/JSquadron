namespace ClassLibrary
{
    public class clsApplication
    {
        // Fields
        public int ApplicationId { get; set; }
        public int? AdminId { get; set; }
        public int? StaffId { get; set; }
        public string ApplicantName { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PoistionApplied { get; set; }
        public string Resume { get; set; }

        // Constructor

        public clsApplication()
        {
        }
        public clsApplication(string applicantName, string emailAddress, string positionApplied, string contactNumber, string resume = null)
        {
            ApplicantName = applicantName;
            EmailAddress = emailAddress;
            ContactNumber = contactNumber;
            PoistionApplied = positionApplied;
            Resume = resume;
        }
       
    }
}
