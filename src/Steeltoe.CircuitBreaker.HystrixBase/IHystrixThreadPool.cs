﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Steeltoe.CircuitBreaker.Hystrix.Strategy.Concurrency;
using System;
using System.Threading.Tasks;

namespace Steeltoe.CircuitBreaker.Hystrix
{
    public interface IHystrixThreadPool : IDisposable
    {
        IHystrixTaskScheduler GetScheduler();

        TaskScheduler GetTaskScheduler();

        void MarkThreadExecution();

        void MarkThreadCompletion();

        void MarkThreadRejection();

        bool IsQueueSpaceAvailable { get; }

        bool IsShutdown { get; }
    }
}