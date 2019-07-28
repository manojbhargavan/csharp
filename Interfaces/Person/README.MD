This Project shows how interfaces can be used effectively to implement a repository pattern and dynamic factory pattern.
In the project PersonViewer change the App.Config to use switch between data sources from were the person data is being fetched.
<add key ="Repository" value="Person.TestMock.TestMockRepository, Person.TestMock, Version=1.0.0.0, Culture=neutral"/>
<!--
<add key ="Repository" value="Person.Csv.CsvRepository, Person.Csv, Version=1.0.0.0, Culture=neutral"/>
-->
<!--
<add key ="Repository" value="Person.Service.ServiceRepository, Person.Service, Version=1.0.0.0, Culture=neutral"/>
-->
