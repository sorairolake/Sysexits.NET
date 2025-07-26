// SPDX-FileCopyrightText: 2025 Shun Sakai
//
// SPDX-License-Identifier: Apache-2.0 OR MIT

namespace Sysexits.Tests;

public class UnitTest
{
    [Fact]
    public void Add()
    {
        var result = ExitCode.Add(2, 2);
        Assert.Equal(4U, result);
    }
}
