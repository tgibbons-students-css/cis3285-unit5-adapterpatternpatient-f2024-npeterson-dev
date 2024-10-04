namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient patient;

        // constructor instantiates an OutNetworkPatient
        public OutNetworkAdapter(string newName, int newPolicyNumber)
        {
            patient = new OutNetworkPatient(newName, newPolicyNumber);
        }

        // implement getPatientName calling method from OutNetworkPatient
        public string getPatientName()
        {
            return patient.getPatientName();
        }

        // implement getPolicyNumber calling method from OutNetworkPatient, convert to string
        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }

        // implement CoverageAmount, multiplying CoveragePercent by procedureCost
        public double CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            decimal coveragePercent = patient.CoveragePercent(ProcedureCost);
            return (coveragePercent * ProcedureCost);
        }

        // implement IsCovered, convert policy number to int and boolean
        public bool IsCovered(string patientName, string policyNumber)
        {
            int policyNumberInt = int.Parse(policyNumber);
            string patient.IsCovered( patientName, policyNumberInt);
        }
    }
}
