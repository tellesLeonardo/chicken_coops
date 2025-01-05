# Imagem base para desenvolvimento com .NET
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev
WORKDIR /workspace

# Adiciona uma conta para o VS Code
RUN useradd -ms /bin/bash vscode
USER vscode

# Configuração opcional para depuração e hot reload
EXPOSE 5000
EXPOSE 5001
CMD ["dotnet", "watch", "run", "--urls", "http://0.0.0.0:5000;https://0.0.0.0:5001"]
