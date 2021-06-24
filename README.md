## Framework.AppSettings
It's a extension for `ConfigurationManager. AppSettings`

### 1. Install

    Install-Package RockLib.Configuration -Version 2.5.2

### 2. The simple example for Asp.Net Mvc
    public class Global : HttpApplication
    {
        using System.Configuration;

        protected void Application_Start(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings.OverwriteFromEnvironment();
        }
    }

You can then override the value of the AppSettings in the web. Config via the Environment

### 3.1 web.config example

    <appSettings>
        <add key="mysql" value="server=localhost;database=demo;uid=root;" />
    </appSettings>

### 3.2 The docker command

    docker run --rm -it \
        -e mysql=server=produce.db;database=demo;uid=root; \
        -p 80:80 \
        dotnetframeworkapplication