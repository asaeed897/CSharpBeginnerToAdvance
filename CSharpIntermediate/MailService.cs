﻿using System;

namespace CSharpIntermediate
{
    public class MailService : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email... ");
            ;
        }
    }
}