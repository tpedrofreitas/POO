using System;

public class NotaInvalidaException : Exception
{
    public NotaInvalidaException(string mensagem) : base(mensagem)
    {
    }
}
