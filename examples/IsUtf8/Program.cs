// SPDX-FileCopyrightText: 2025 Shun Sakai
//
// SPDX-License-Identifier: Apache-2.0 OR MIT

using System.CommandLine;
using System.Text;

using Sysexits;

class Program
{
    static int Main(string[] args)
    {
        Argument<string> inputArgument = new("FILE")
        {
            Description = "File to check.",
        };

        RootCommand rootCommand = new("An example of checking whether the input is valid UTF-8.");
        rootCommand.Arguments.Add(inputArgument);

        rootCommand.SetAction(parseResult =>
        {
            var input = File.ReadAllBytes(parseResult.GetRequiredValue(inputArgument));
            UTF8Encoding utf8 = new(false, true);
            try
            {
                _ = utf8.GetString(input);
                Console.WriteLine("OK");
                return (int)ExitCode.Ok;
            }
            catch (DecoderFallbackException ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                return (int)ExitCode.DataErr;
            }
        });

        var parseResult = rootCommand.Parse(args);
        return parseResult.Invoke();
    }
}
