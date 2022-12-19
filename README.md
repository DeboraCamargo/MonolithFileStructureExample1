SpikeMono

Separate by Layers - Layer in folders


the simplest one - out of the box

pro
Just one project
easy to implement
don't have to create references

cons
Just one project (can get messy and hard to find things as the project grows)


how deploy would work on the Frontend piece

have our be to create output
dotnet publish -o output

run build on vue
npm run build (on vue)

it will generate a dist file

copy that content into output>wwwroot on the backend

that would could be added to dockerfile