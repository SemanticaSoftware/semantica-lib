using System.Diagnostics;
using System.Net.Mail;

namespace Semantica.Types;

[DebuggerDisplay("EmailAddress: {Value}")]
public readonly record struct EmailAddress(string Value)
{
    public override string ToString() => Value;

    public static implicit operator string(EmailAddress emailAddress) => emailAddress.Value;

    public static implicit operator EmailAddress(string value) => new EmailAddress(value);
    

    public static implicit operator MailAddress(EmailAddress emailAddress) => new MailAddress(emailAddress.Value);

    public static implicit operator EmailAddress(MailAddress mailAddress) => new EmailAddress(mailAddress.Address);
}
