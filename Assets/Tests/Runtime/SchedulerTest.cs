using System.Threading;
using UnityEngine;

namespace Fizz6.Scheduler.Tests
{
    public class SchedulerTest : MonoBehaviour
    {
        private async void Awake()
        {
            var cancellationToken = new CancellationToken();
            await this.WaitUntilUpdate(2.0f, cancellationToken);
            Debug.LogError("Invoke In Update");
        }
    }
}