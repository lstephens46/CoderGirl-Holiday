using Holiday;
using System;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void DayReturning_ReturnValue()
        {
            object result = Program.DayReturning(DateTime.Today, (((int)DayOfWeek.Monday - (int)DateTime.Today.DayOfWeek + 7) % 7) + 1);

            if (result is DayOfWeek)
                Assert.Equal(DayOfWeek.Tuesday, result);
            else
                Assert.Equal("Tuesday", result);
        }
    }
}
