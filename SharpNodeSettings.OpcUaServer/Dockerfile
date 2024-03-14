# 使用 .NET Framework 作为基础镜像
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build-env

# 设置工作目录
WORKDIR /app

# 将 .NET Framework 应用程序项目文件复制到工作目录中
COPY SharpNodeSettings.OpcUaServer.csproj ./

# 使用 NuGet 恢复依赖项
RUN nuget restore

# 将应用程序文件复制到工作目录中
COPY . ./

# 构建应用程序
RUN msbuild /p:Configuration=Release

# 创建最终运行时镜像
FROM mcr.microsoft.com/dotnet/framework/sdk:4.8
WORKDIR /app
COPY --from=build-env /app/bin/Release .
ENTRYPOINT ["SharpNodeSettings.OpcUaServer.exe"]