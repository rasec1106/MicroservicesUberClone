namespace ApiDriver.Dto
{
    public class ResponseDto
    {
        public bool IsSuceed { get; set; }
        public object? Result { get; set; }
        public string DisplayMessage { get; set; } = "";
    }
}
