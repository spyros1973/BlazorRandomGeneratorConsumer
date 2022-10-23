# BlazorConsumer

This is a simple Blazor Server app (using Bulma as a CSS framework) that generates random content (job titles and political speeches for the time being). It supports english and greek content generation.

The actual generation part is handled by a project called Random Generator - this is currently not public in my account, but the source code points to an installation of it in Azure. The "generation" code consists of simplistic random choices from premade lists of words and sentences - nothing fancy here.

For example, when generating job titles in english, you can expect output like:
["Internal DevOps Ambassador","Customer Workflow Generator","Backup Operations Receiver","Generic Analysis Engineer","Senior Research Evangelist"] and other nonsensical stuff.

It is a just for fun project, made to play around with Blazor, Web API and Bulma.
