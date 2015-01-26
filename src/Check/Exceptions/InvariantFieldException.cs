namespace Check.Exceptions
{
    public class InvariantFieldException : InvariantException
    {
        protected readonly string FieldName;

        public InvariantFieldException(string fieldName, string message)
            : base(message)
        {
            FieldName = fieldName;
        }

        protected override string AutoMessage
        {
            get { return string.Format("{0} is invalid", FieldName); }
        }
    }
}