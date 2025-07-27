// SPDX-FileCopyrightText: 2025 Shun Sakai
//
// SPDX-License-Identifier: Apache-2.0 OR MIT

namespace Sysexits;

/// <summary>
/// Represents the system exit code constants as defined by
/// <see href="https://man.openbsd.org/sysexits"><c>&lt;sysexits.h&gt;</c></see>.
/// </summary>
public enum ExitCode : byte
{
    /// <summary>
    /// The successful exit.
    /// </summary>
    Ok,

    /// <summary>
    /// The base value for <c>ExitCode</c>.
    /// </summary>
    /// <remarks>
    /// See
    /// <see href="https://man7.org/linux/man-pages/man3/sysexits.h.3head.html"><c>sysexits.h(3head)</c></see>
    /// for details.
    /// </remarks>
    Base = 64,

    /// <summary>
    /// The command was used incorrectly, e.g., with the wrong number of
    /// arguments, a bad flag, bad syntax in a parameter, or whatever.
    /// </summary>
    Usage = Base,

    /// <summary>
    /// The input data was incorrect in some way. This should only be used for
    /// user's data and not system files.
    /// </summary>
    DataErr,

    /// <summary>
    /// An input file (not a system file) did not exist or was not readable.
    /// This could also include errors like "No message" to a mailer (if it
    /// cared to catch it).
    /// </summary>
    NoInput,

    /// <summary>
    /// The user specified did not exist. This might be used for mail addresses
    /// or remote logins.
    /// </summary>
    NoUser,

    /// <summary>
    /// The host specified did not exist. This is used in mail addresses or
    /// network requests.
    /// </summary>
    NoHost,

    /// <summary>
    /// A service is unavailable. This can occur if a support program or file
    /// does not exist. This can also be used as a catch-all message when
    /// something you wanted to do doesn't work, but you don't know why.
    /// </summary>
    Unavailable,

    /// <summary>
    /// An internal software error has been detected. This should be limited to
    /// non-operating system related errors if possible.
    /// </summary>
    Software,

    /// <summary>
    /// An operating system error has been detected. This is intended to be
    /// used for such things as "cannot fork", or "cannot create pipe". It
    /// includes things like
    /// <see href="https://man.openbsd.org/getuid.2"><c>getuid(2)</c></see>
    /// returning a user that does not exist in the passwd file.
    /// </summary>
    OsErr,

    /// <summary>
    /// Some system file (e.g., <c>/etc/passwd</c>, <c>/var/run/utmp</c>) does
    /// not exist, cannot be opened, or has some sort of error (e.g., syntax
    /// error).
    /// </summary>
    OsFile,

    /// <summary>
    /// A (user specified) output file cannot be created.
    /// </summary>
    CantCreat,

    /// <summary>
    /// An error occurred while doing I/O on some file.
    /// </summary>
    IoErr,

    /// <summary>
    /// Temporary failure, indicating something that is not really an error.
    /// For example that a mailer could not create a connection, and the
    /// request should be reattempted later.
    /// </summary>
    TempFail,

    /// <summary>
    /// The remote system returned something that was "not possible" during a
    /// protocol exchange.
    /// </summary>
    Protocol,

    /// <summary>
    /// You did not have sufficient permission to perform the operation. This
    /// is not intended for file system problems, which should use
    /// <see cref="NoInput"/> or <see cref="CantCreat"/>, but rather for higher
    /// level permissions.
    /// </summary>
    NoPerm,

    /// <summary>
    /// Something was found in an unconfigured or misconfigured state.
    /// </summary>
    Config,

    /// <summary>
    /// The maximum value for <c>ExitCode</c>.
    /// </summary>
    /// <remarks>
    /// See
    /// <see href="https://man7.org/linux/man-pages/man3/sysexits.h.3head.html"><c>sysexits.h(3head)</c></see>
    /// for details.
    /// </remarks>
    Max = Config,
}

/// <summary>
/// Extension members for <see cref="ExitCode"/>.
/// </summary>
public static class ExitCodeExt
{
    /// <summary>
    /// Determines whether this system exit code represents successful
    /// termination.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if this system exit code represents successful
    /// termination, <see langword="false"/> otherwise.
    /// </returns>
    /// <param name="code">The exit code to inspect.</param>
    public static bool IsSuccess(this ExitCode code) =>
        code == ExitCode.Ok;

    /// <summary>
    /// Determines whether this system exit code represents unsuccessful
    /// termination.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if this system exit code represents unsuccessful
    /// termination, <see langword="false"/> otherwise.
    /// </returns>
    /// <param name="code">The exit code to inspect.</param>
    public static bool IsFailure(this ExitCode code) =>
        !code.IsSuccess();

    /// <summary>
    /// Terminates the current process with the exit code defined by
    /// <c>ExitCode</c>.
    /// </summary>
    /// <param name="code">
    /// The exit code to return to the operating system.
    /// </param>
    /// <exception cref="System.Security.SecurityException">
    /// The caller does not have sufficient security permission to perform this
    /// function.
    /// </exception>
    public static void Exit(this ExitCode code) =>
        Environment.Exit((int)code);
}
