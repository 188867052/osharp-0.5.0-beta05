dotnet build

cd src/ui/ng-alain
npm install && npm run-script build && del ..\..\Blogs.Web\wwwroot\* /q && copy dist\* ..\..\Blogs.Web\wwwroot\ && cd ..\..\Blogs.Web && dotnet build -c Release && dotnet publish -c Release && cd ..\..\ && docker build -t blogs.web .
