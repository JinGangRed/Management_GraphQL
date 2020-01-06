﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDomain.Operations.Querys
{
    public class Query:ObjectGraphType
    {
        public Query()
        {
            Name = "Query";
            Field<AccountGroupQuery>("Account", resolve: context => new { });
            Field<CompanyGroupQuery>("Company", resolve: context => new { });
            Field<EmployeeGroupQuery>("Employee", resolve: context => new { });
        }
    }
}
