﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Commands
{
    public interface ICommand
    {
       string Execute(params string[] args);
    }
}
