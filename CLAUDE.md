# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

MusicLibrary is a Windows desktop application for managing large music libraries, built with .NET 8 and Windows Forms. It provides music file indexing, metadata management, search capabilities, and audio format conversion.

## Commands

### Build and Test
```bash
# Build the entire solution
dotnet build MusicLibrary.sln

# Run all tests
dotnet test MusicLibrary.Tests/

# Run a specific test
dotnet test MusicLibrary.Tests/ --filter "FullyQualifiedName~TestClassName.TestMethodName"

# Run the application
dotnet run --project MusicLibrary.Forms/

# Publish for Windows x64
dotnet publish MusicLibrary.Forms/ -c Release -r win-x64 --self-contained true
```

## Architecture

### Solution Structure
The solution follows a layered architecture with 5 projects:

1. **MusicLibrary.Forms** (Presentation Layer)
   - Windows Forms UI application
   - Entry point: `Program.cs` with dependency injection setup
   - Main window: `MainForm.cs` with tab-based interface
   - Forms for file conversion, metadata editing, and online lookup

2. **MusicLibrary.Business** (Business Logic)
   - Core services orchestrating all operations
   - `FileIndexer`: Parallel file scanning and indexing
   - `IndexSearcher`: Search operations with faceted filtering
   - `FileConverter`: Audio format conversion via FFmpeg
   - `MetaTagsService`: Metadata CRUD operations
   - `MusicBrainzService`: Online metadata retrieval

3. **MusicLibrary.Indexer** (Search Engine)
   - Generic Lucene.NET implementation
   - `GenericSearchIndexEngine<T>`: Core search engine with attribute-based mapping
   - Custom attributes: `SearchableAttribute`, `FacetPropertyAttribute`, `StoredPropertyAttribute`
   - Supports faceted search and parallel indexing

4. **MusicLibrary.Common** (Shared)
   - Constants, extensions, and utility classes
   - Progress reporting models for async operations

5. **MusicLibrary.Tests** (Testing)
   - MSTest unit tests
   - Test resources in `Resources/` folder

### Key Design Patterns

- **Dependency Injection**: Microsoft.Extensions.DependencyInjection in Program.cs
- **Generic Repository**: Strongly-typed document mapping for Lucene.NET
- **Async/Await**: All long-running operations support cancellation and progress reporting
- **Parallel Processing**: Configurable parallelism for file scanning and indexing

### Data Storage

- **Index Location**: `%LocalAppData%\MusicLibrary\index\`
- **Shared Libraries**: `%LocalAppData%\MusicLibrary\shares\`
- **User Lists**: `%LocalAppData%\MusicLibrary\lists\`

### External Dependencies

- **Lucene.NET**: Full-text search and indexing
- **ATL (z440.atl.core)**: Music metadata extraction
- **FFmpeg (Xabe.FFmpeg)**: Audio format conversion
- **MusicBrainz (MetaBrainz.MusicBrainz)**: Online metadata lookup

### Search System

The search engine uses attribute-based mapping to convert between domain models and Lucene documents:

- `[Searchable]`: Marks properties for full-text search
- `[FacetProperty]`: Enables faceted filtering
- `[StoredProperty]`: Stores values in index for retrieval

Facets supported: Artist, Release, Genre, Year, Extension

### File Processing Flow

1. **Scanning**: Recursively scans directories for MP3/FLAC files
2. **Metadata Extraction**: Uses ATL to read tags
3. **Indexing**: Creates Lucene documents with parallel processing
4. **Search**: Full-text search with faceted filtering
5. **Conversion**: Optional MP3/FLAC conversion via FFmpeg