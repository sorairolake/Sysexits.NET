// SPDX-FileCopyrightText: 2025 Shun Sakai
//
// SPDX-License-Identifier: Apache-2.0 OR MIT

namespace Sysexits.Tests;

public class UnitTest
{
    [Fact]
    public void ExitCodeToInteger()
    {
        Assert.Equal(0, (int)ExitCode.Ok);
        Assert.Equal(64, (int)ExitCode.Usage);
        Assert.Equal(65, (int)ExitCode.DataErr);
        Assert.Equal(66, (int)ExitCode.NoInput);
        Assert.Equal(67, (int)ExitCode.NoUser);
        Assert.Equal(68, (int)ExitCode.NoHost);
        Assert.Equal(69, (int)ExitCode.Unavailable);
        Assert.Equal(70, (int)ExitCode.Software);
        Assert.Equal(71, (int)ExitCode.OsErr);
        Assert.Equal(72, (int)ExitCode.OsFile);
        Assert.Equal(73, (int)ExitCode.CantCreat);
        Assert.Equal(74, (int)ExitCode.IoErr);
        Assert.Equal(75, (int)ExitCode.TempFail);
        Assert.Equal(76, (int)ExitCode.Protocol);
        Assert.Equal(77, (int)ExitCode.NoPerm);
        Assert.Equal(78, (int)ExitCode.Config);
    }

    [Fact]
    public void Base() =>
        Assert.Equal(ExitCode.Usage, ExitCode.Base);

    [Fact]
    public void Max() =>
        Assert.Equal(ExitCode.Config, ExitCode.Max);

    [Fact]
    public void IsSuccessForSuccessfulTermination() =>
        Assert.True(ExitCode.Ok.IsSuccess());

    [Fact]
    public void IsSuccessForUnsuccessfulTermination()
    {
        Assert.False(ExitCode.Usage.IsSuccess());
        Assert.False(ExitCode.DataErr.IsSuccess());
        Assert.False(ExitCode.NoInput.IsSuccess());
        Assert.False(ExitCode.NoUser.IsSuccess());
        Assert.False(ExitCode.NoHost.IsSuccess());
        Assert.False(ExitCode.Unavailable.IsSuccess());
        Assert.False(ExitCode.Software.IsSuccess());
        Assert.False(ExitCode.OsErr.IsSuccess());
        Assert.False(ExitCode.OsFile.IsSuccess());
        Assert.False(ExitCode.CantCreat.IsSuccess());
        Assert.False(ExitCode.IoErr.IsSuccess());
        Assert.False(ExitCode.TempFail.IsSuccess());
        Assert.False(ExitCode.Protocol.IsSuccess());
        Assert.False(ExitCode.NoPerm.IsSuccess());
        Assert.False(ExitCode.Config.IsSuccess());
    }

    [Fact]
    public void IsFailureForSuccessfulTermination() =>
        Assert.False(ExitCode.Ok.IsFailure());

    [Fact]
    public void IsFailureForUnsuccessfulTermination()
    {
        Assert.True(ExitCode.Usage.IsFailure());
        Assert.True(ExitCode.DataErr.IsFailure());
        Assert.True(ExitCode.NoInput.IsFailure());
        Assert.True(ExitCode.NoUser.IsFailure());
        Assert.True(ExitCode.NoHost.IsFailure());
        Assert.True(ExitCode.Unavailable.IsFailure());
        Assert.True(ExitCode.Software.IsFailure());
        Assert.True(ExitCode.OsErr.IsFailure());
        Assert.True(ExitCode.OsFile.IsFailure());
        Assert.True(ExitCode.CantCreat.IsFailure());
        Assert.True(ExitCode.IoErr.IsFailure());
        Assert.True(ExitCode.TempFail.IsFailure());
        Assert.True(ExitCode.Protocol.IsFailure());
        Assert.True(ExitCode.NoPerm.IsFailure());
        Assert.True(ExitCode.Config.IsFailure());
    }
}
