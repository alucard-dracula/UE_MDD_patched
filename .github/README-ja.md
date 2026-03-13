# UE_MDD_patched

- [简体中文](/./README.md)
- [English](/.github/README-en_us.md)
- **日本語**

---

Win64 上で Unread Engine の /MDD Debug 版をコンパイルするためのパッチ

基本的な使用方法：

1. 対応する UE バージョンのソースコードをダウンロードする
2. "%UnrealEngine_RootDir%/Setup.bat" を一度実行する
3. "%UnrealEngine_RootDir%/GenerateProjectFiles.bat" を一度実行する
4. パッチディレクトリ内のすべてのファイルを %UnrealEngine_RootDir% にコピーする
5. "%UnrealEngine_RootDir%/make_installed_build.bat" を実行する
6. さらに詳しい説明は、各パッチディレクトリ内の readme.txt を参照する

注意事項:
1. WINDOWS でのディレクトリパスが長すぎる問題を避けるため、Unread Engine のルートディレクトリはできるだけ WINDOWS の任意のドライブのルートに置くこと。
2. 単一ドライブに 600GB 以上の空き容量を用意する（推奨 800GB 以上）

PS:
このプロジェクトは UE 5.7.3 バージョンから開始。個人の能力に限りがあるため、すべてのバージョンにパッチがあることは保証できません。

