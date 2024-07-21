using System;
using System.Globalization;

public static class ExtensionString
{
    public static string FormatNumber(this int n)
    {
        if (n < 1000) return n.ToString(CultureInfo.InvariantCulture);

        if (n < 10000) return String.Format(CultureInfo.InvariantCulture, "{0:#,.#}K", n - 5);

        if (n < 100000) return String.Format(CultureInfo.InvariantCulture, "{0:#,.#}K", n - 50);

        if (n < 1000000) return String.Format(CultureInfo.InvariantCulture, "{0:#,.}K", n - 500);

        if (n < 10000000) return String.Format(CultureInfo.InvariantCulture, "{0:#,,.#}M", n - 5000);

        if (n < 100000000) return String.Format(CultureInfo.InvariantCulture, "{0:#,,.#}M", n - 50000);

        if (n < 1000000000) return String.Format(CultureInfo.InvariantCulture, "{0:#,,.}M", n - 500000);

        return String.Format(CultureInfo.InvariantCulture, "{0:#,,,.##}B", n - 5000000);
    }
}
