1. Install tools
```bash
dotnet tool install -g dotnet-script
```

2. Create scripts
```bash
touch hello.csx
echo 'Console.WriteLine("Hello, World from script");' > hello.csx
```

3. Run
```bash
dotnet script hello.csx

