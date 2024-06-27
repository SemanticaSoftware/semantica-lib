using System.Net.Mail;

namespace Semantica.Types;

/// <summary>
/// Provides extension methods for <see cref="EmailAddress"/>.
/// </summary>
public static class EmailAddressExtensions
{
    /// <summary>
    /// Checks technical validity of the email, using System.Net.Mail.<see cref="MailAddress"/>.
    /// </summary>
    /// <remarks>
    /// from <a href="https://stackoverflow.com/questions/1365407/c-sharp-code-to-validate-email-address">StackOverflow</a>
    /// </remarks>
    public static bool IsValid(this EmailAddress email)
    {
        var value = email.Value.Trim();
        if (string.IsNullOrEmpty(value) || value.EndsWith("."))
        {
            return false;
        }

        try
        {
            return ((MailAddress)(email)).Address == value;
        }
        catch
        {
            return false;
        }
    }
}
