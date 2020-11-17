namespace Architecture.Model
{
    public sealed class TokenModel
    {
        public TokenModel(string token)
        {
            Token = token;
        }

        public string Token { get; }
    }
}
