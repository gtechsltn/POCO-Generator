﻿using System;
using POCOGenerator.DbObjects;

namespace POCOGenerator.POCOIterators
{
    #region Server

    public sealed class ServerGeneratingAsyncEventArgs : EventArgs
    {
        internal ServerGeneratingAsyncEventArgs(IServer server)
        {
            this.Server = server;
        }

        public IServer Server { get; private set; }
    }

    public sealed class ServerGeneratingEventArgs : EventArgs
    {
        internal ServerGeneratingEventArgs(IServer server)
        {
            this.Server = server;
        }

        public IServer Server { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class ServerGeneratedAsyncEventArgs : EventArgs
    {
        internal ServerGeneratedAsyncEventArgs(IServer server)
        {
            this.Server = server;
        }

        public IServer Server { get; private set; }
    }

    public sealed class ServerGeneratedEventArgs : EventArgs
    {
        internal ServerGeneratedEventArgs(IServer server)
        {
            this.Server = server;
        }

        public IServer Server { get; private set; }
        public bool Stop { get; set; }
    }

    #endregion

    #region Database

    public sealed class DatabaseGeneratingAsyncEventArgs : EventArgs
    {
        internal DatabaseGeneratingAsyncEventArgs(IDatabase database)
        {
            this.Database = database;
        }

        public IDatabase Database { get; private set; }
    }

    public sealed class DatabaseGeneratingEventArgs : EventArgs
    {
        internal DatabaseGeneratingEventArgs(IDatabase database)
        {
            this.Database = database;
        }

        public IDatabase Database { get; private set; }
        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class DatabaseGeneratedAsyncEventArgs : EventArgs
    {
        internal DatabaseGeneratedAsyncEventArgs(IDatabase database)
        {
            this.Database = database;
        }

        public IDatabase Database { get; private set; }
    }

    public sealed class DatabaseGeneratedEventArgs : EventArgs
    {
        internal DatabaseGeneratedEventArgs(IDatabase database)
        {
            this.Database = database;
        }

        public IDatabase Database { get; private set; }
        public bool Stop { get; set; }
    }

    #endregion

    #region Table

    public sealed class TablesGeneratingAsyncEventArgs : EventArgs
    {
        internal TablesGeneratingAsyncEventArgs()
        {
        }
    }

    public sealed class TablesGeneratingEventArgs : EventArgs
    {
        internal TablesGeneratingEventArgs()
        {
        }

        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class TableGeneratingAsyncEventArgs : EventArgs
    {
        internal TableGeneratingAsyncEventArgs(ITable table, string @namespace)
        {
            this.Table = table;
            this.Namespace = @namespace;
        }

        public ITable Table { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class TableGeneratingEventArgs : EventArgs
    {
        internal TableGeneratingEventArgs(ITable table, string @namespace)
        {
            this.Table = table;
            this.Namespace = @namespace;
        }

        public ITable Table { get; private set; }
        public string Namespace { get; set; }
        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class TablePOCOAsyncEventArgs : EventArgs
    {
        internal TablePOCOAsyncEventArgs(ITable table, string poco)
        {
            this.Table = table;
            this.POCO = poco;
        }

        public ITable Table { get; private set; }
        public string POCO { get; private set; }
    }

    public sealed class TablePOCOEventArgs : EventArgs
    {
        internal TablePOCOEventArgs(ITable table, string poco)
        {
            this.Table = table;
            this.POCO = poco;
        }

        public ITable Table { get; private set; }
        public string POCO { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class TableGeneratedAsyncEventArgs : EventArgs
    {
        internal TableGeneratedAsyncEventArgs(ITable table, string @namespace)
        {
            this.Table = table;
            this.Namespace = @namespace;
        }

        public ITable Table { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class TableGeneratedEventArgs : EventArgs
    {
        internal TableGeneratedEventArgs(ITable table, string @namespace)
        {
            this.Table = table;
            this.Namespace = @namespace;
        }

        public ITable Table { get; private set; }
        public string Namespace { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class TablesGeneratedAsyncEventArgs : EventArgs
    {
        internal TablesGeneratedAsyncEventArgs()
        {
        }
    }

    public sealed class TablesGeneratedEventArgs : EventArgs
    {
        internal TablesGeneratedEventArgs()
        {
        }

        public bool Stop { get; set; }
    }

    #endregion

    #region View

    public sealed class ViewsGeneratingAsyncEventArgs : EventArgs
    {
        internal ViewsGeneratingAsyncEventArgs()
        {
        }
    }

    public sealed class ViewsGeneratingEventArgs : EventArgs
    {
        internal ViewsGeneratingEventArgs()
        {
        }

        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class ViewGeneratingAsyncEventArgs : EventArgs
    {
        internal ViewGeneratingAsyncEventArgs(IView view, string @namespace)
        {
            this.View = view;
            this.Namespace = @namespace;
        }

        public IView View { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class ViewGeneratingEventArgs : EventArgs
    {
        internal ViewGeneratingEventArgs(IView view, string @namespace)
        {
            this.View = view;
            this.Namespace = @namespace;
        }

        public IView View { get; private set; }
        public string Namespace { get; set; }
        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class ViewPOCOAsyncEventArgs : EventArgs
    {
        internal ViewPOCOAsyncEventArgs(IView view, string poco)
        {
            this.View = view;
            this.POCO = poco;
        }

        public IView View { get; private set; }
        public string POCO { get; private set; }
    }

    public sealed class ViewPOCOEventArgs : EventArgs
    {
        internal ViewPOCOEventArgs(IView view, string poco)
        {
            this.View = view;
            this.POCO = poco;
        }

        public IView View { get; private set; }
        public string POCO { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class ViewGeneratedAsyncEventArgs : EventArgs
    {
        internal ViewGeneratedAsyncEventArgs(IView view, string @namespace)
        {
            this.View = view;
            this.Namespace = @namespace;
        }

        public IView View { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class ViewGeneratedEventArgs : EventArgs
    {
        internal ViewGeneratedEventArgs(IView view, string @namespace)
        {
            this.View = view;
            this.Namespace = @namespace;
        }

        public IView View { get; private set; }
        public string Namespace { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class ViewsGeneratedAsyncEventArgs : EventArgs
    {
        internal ViewsGeneratedAsyncEventArgs()
        {
        }
    }

    public sealed class ViewsGeneratedEventArgs : EventArgs
    {
        internal ViewsGeneratedEventArgs()
        {
        }

        public bool Stop { get; set; }
    }

    #endregion

    #region Procedure

    public sealed class ProceduresGeneratingAsyncEventArgs : EventArgs
    {
        internal ProceduresGeneratingAsyncEventArgs()
        {
        }
    }

    public sealed class ProceduresGeneratingEventArgs : EventArgs
    {
        internal ProceduresGeneratingEventArgs()
        {
        }

        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class ProcedureGeneratingAsyncEventArgs : EventArgs
    {
        internal ProcedureGeneratingAsyncEventArgs(IProcedure procedure, string @namespace)
        {
            this.Procedure = procedure;
            this.Namespace = @namespace;
        }

        public IProcedure Procedure { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class ProcedureGeneratingEventArgs : EventArgs
    {
        internal ProcedureGeneratingEventArgs(IProcedure procedure, string @namespace)
        {
            this.Procedure = procedure;
            this.Namespace = @namespace;
        }

        public IProcedure Procedure { get; private set; }
        public string Namespace { get; set; }
        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class ProcedurePOCOAsyncEventArgs : EventArgs
    {
        internal ProcedurePOCOAsyncEventArgs(IProcedure procedure, string poco)
        {
            this.Procedure = procedure;
            this.POCO = poco;
        }

        public IProcedure Procedure { get; private set; }
        public string POCO { get; private set; }
    }

    public sealed class ProcedurePOCOEventArgs : EventArgs
    {
        internal ProcedurePOCOEventArgs(IProcedure procedure, string poco)
        {
            this.Procedure = procedure;
            this.POCO = poco;
        }

        public IProcedure Procedure { get; private set; }
        public string POCO { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class ProcedureGeneratedAsyncEventArgs : EventArgs
    {
        internal ProcedureGeneratedAsyncEventArgs(IProcedure procedure, string @namespace)
        {
            this.Procedure = procedure;
            this.Namespace = @namespace;
        }

        public IProcedure Procedure { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class ProcedureGeneratedEventArgs : EventArgs
    {
        internal ProcedureGeneratedEventArgs(IProcedure procedure, string @namespace)
        {
            this.Procedure = procedure;
            this.Namespace = @namespace;
        }

        public IProcedure Procedure { get; private set; }
        public string Namespace { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class ProceduresGeneratedAsyncEventArgs : EventArgs
    {
        internal ProceduresGeneratedAsyncEventArgs()
        {
        }
    }

    public sealed class ProceduresGeneratedEventArgs : EventArgs
    {
        internal ProceduresGeneratedEventArgs()
        {
        }

        public bool Stop { get; set; }
    }

    #endregion

    #region Function

    public sealed class FunctionsGeneratingAsyncEventArgs : EventArgs
    {
        internal FunctionsGeneratingAsyncEventArgs()
        {
        }
    }

    public sealed class FunctionsGeneratingEventArgs : EventArgs
    {
        internal FunctionsGeneratingEventArgs()
        {
        }

        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class FunctionGeneratingAsyncEventArgs : EventArgs
    {
        internal FunctionGeneratingAsyncEventArgs(IFunction function, string @namespace)
        {
            this.Function = function;
            this.Namespace = @namespace;
        }

        public IFunction Function { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class FunctionGeneratingEventArgs : EventArgs
    {
        internal FunctionGeneratingEventArgs(IFunction function, string @namespace)
        {
            this.Function = function;
            this.Namespace = @namespace;
        }

        public IFunction Function { get; private set; }
        public string Namespace { get; set; }
        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class FunctionPOCOAsyncEventArgs : EventArgs
    {
        internal FunctionPOCOAsyncEventArgs(IFunction function, string poco)
        {
            this.Function = function;
            this.POCO = poco;
        }

        public IFunction Function { get; private set; }
        public string POCO { get; private set; }
    }

    public sealed class FunctionPOCOEventArgs : EventArgs
    {
        internal FunctionPOCOEventArgs(IFunction function, string poco)
        {
            this.Function = function;
            this.POCO = poco;
        }

        public IFunction Function { get; private set; }
        public string POCO { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class FunctionGeneratedAsyncEventArgs : EventArgs
    {
        internal FunctionGeneratedAsyncEventArgs(IFunction function, string @namespace)
        {
            this.Function = function;
            this.Namespace = @namespace;
        }

        public IFunction Function { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class FunctionGeneratedEventArgs : EventArgs
    {
        internal FunctionGeneratedEventArgs(IFunction function, string @namespace)
        {
            this.Function = function;
            this.Namespace = @namespace;
        }

        public IFunction Function { get; private set; }
        public string Namespace { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class FunctionsGeneratedAsyncEventArgs : EventArgs
    {
        internal FunctionsGeneratedAsyncEventArgs()
        {
        }
    }

    public sealed class FunctionsGeneratedEventArgs : EventArgs
    {
        internal FunctionsGeneratedEventArgs()
        {
        }

        public bool Stop { get; set; }
    }

    #endregion

    #region TVP

    public sealed class TVPsGeneratingAsyncEventArgs : EventArgs
    {
        internal TVPsGeneratingAsyncEventArgs()
        {
        }
    }

    public sealed class TVPsGeneratingEventArgs : EventArgs
    {
        internal TVPsGeneratingEventArgs()
        {
        }

        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class TVPGeneratingAsyncEventArgs : EventArgs
    {
        internal TVPGeneratingAsyncEventArgs(ITVP tvp, string @namespace)
        {
            this.TVP = tvp;
            this.Namespace = @namespace;
        }

        public ITVP TVP { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class TVPGeneratingEventArgs : EventArgs
    {
        internal TVPGeneratingEventArgs(ITVP tvp, string @namespace)
        {
            this.TVP = tvp;
            this.Namespace = @namespace;
        }

        public ITVP TVP { get; private set; }
        public string Namespace { get; set; }
        public bool Skip { get; set; }
        public bool Stop { get; set; }
    }

    public sealed class TVPPOCOAsyncEventArgs : EventArgs
    {
        internal TVPPOCOAsyncEventArgs(ITVP tvp, string poco)
        {
            this.TVP = tvp;
            this.POCO = poco;
        }

        public ITVP TVP { get; private set; }
        public string POCO { get; private set; }
    }

    public sealed class TVPPOCOEventArgs : EventArgs
    {
        internal TVPPOCOEventArgs(ITVP tvp, string poco)
        {
            this.TVP = tvp;
            this.POCO = poco;
        }

        public ITVP TVP { get; private set; }
        public string POCO { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class TVPGeneratedAsyncEventArgs : EventArgs
    {
        internal TVPGeneratedAsyncEventArgs(ITVP tvp, string @namespace)
        {
            this.TVP = tvp;
            this.Namespace = @namespace;
        }

        public ITVP TVP { get; private set; }
        public string Namespace { get; private set; }
    }

    public sealed class TVPGeneratedEventArgs : EventArgs
    {
        internal TVPGeneratedEventArgs(ITVP tvp, string @namespace)
        {
            this.TVP = tvp;
            this.Namespace = @namespace;
        }

        public ITVP TVP { get; private set; }
        public string Namespace { get; private set; }
        public bool Stop { get; set; }
    }

    public sealed class TVPsGeneratedAsyncEventArgs : EventArgs
    {
        internal TVPsGeneratedAsyncEventArgs()
        {
        }
    }

    public sealed class TVPsGeneratedEventArgs : EventArgs
    {
        internal TVPsGeneratedEventArgs()
        {
        }

        public bool Stop { get; set; }
    }

    #endregion
}
