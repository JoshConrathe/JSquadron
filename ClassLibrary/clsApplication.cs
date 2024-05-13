namespace ClassLibrary
{
    public class clsApplication
    {
        // Fields
        public int ApplicationId { get; private set; }
        public int? AdminId { get; set; }
        public int? StaffId { get; set; }
        public string ApplicantName { get; private set; }
        public string ContactNumber { get; private set; }
        public string EmailAddress { get; private set; }
        public string PoistionApplied { get; private set; }
        public string Resume { get; private set; }

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
