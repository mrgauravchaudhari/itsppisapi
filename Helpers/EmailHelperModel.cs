namespace itsppisapi.Helpers
{
    public class EmailHelperModel
    {
        public EmailHelperModel(string to, string alias, string subject, string message, bool isBodyHtml)
        {
            To = to;
            Alias = alias;
            Subject = subject;
            Message = message;
            IsBodyHtml = isBodyHtml;
        }
        public string To { get; }
        public string Alias { get; }
        public string Subject { get; }
        public string Message { get; }
        public bool IsBodyHtml { get; }

    }
}