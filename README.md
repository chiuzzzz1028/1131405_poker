# 1131405_上課練習：五張撲克牌

## 專案簡介
本專案為 **C# Windows Forms** 開發的撲克牌遊戲。除了基本的發牌、換牌與牌型判斷功能外，並新增了完整的**下注系統**與**中獎金額計算**。使用者可以設定押注金額，並根據最終牌型的賠率獲取獎金。

## 功能特點
* **流程控制**：透過按鈕狀態（Enabled）切換，確保玩家必須依循 `押注 -> 發牌 -> 換牌 -> 判斷牌型` 的順序進行遊戲。
* **賠率結算系統**：自動判斷牌型並依照賠率表計算獎金，中獎後自動加回總資金。
* **介面設計**：優化結果顯示框，確保高額獎金與牌型資訊能清晰呈現不被切除，並且會提醒使用者餘額不足或是沒有輸入金額的情況。
* **測試模式**：內建測試用快捷鍵，方便快速驗證各種中獎牌型(如同花、四條、葫蘆等等牌型)。

## 如何執行
**步驟**：
    1. 輸入「押注金額」並點擊 **[押注]**。
    2. 點擊 **[發牌]**。
    3. 點選牌面以「蓋牌」（選擇想更換的牌）。
    4. 點擊 **[換牌]**。
    5. 點擊 **[判斷牌型]** 查看結果與獎金。
    
## 執行截圖與說明
**範例一**：正常情況下使用執行結果
<img width="1044" height="745" alt="image" src="https://github.com/user-attachments/assets/ca281c9b-2d6c-4fca-8752-c2840670b886" />
換牌情況：選擇想要的撲克牌，會將所選取的撲克牌翻轉成背面
<img width="1022" height="709" alt="image" src="https://github.com/user-attachments/assets/0a43c105-7ae5-4713-83bc-407f7c34c730" />
<img width="1038" height="737" alt="image" src="https://github.com/user-attachments/assets/e078ee4e-ee11-47b0-9909-c3fb8a7a8401" />
顯示牌型：
<img width="1036" height="734" alt="image" src="https://github.com/user-attachments/assets/9329f145-730f-4c23-a1a2-753b7a3a5a5a" />

**範例二**：使用內建快捷鍵
原本牌型：
<img width="1047" height="738" alt="image" src="https://github.com/user-attachments/assets/ae6cde41-acb8-4a05-a66f-3a6960454592" />
點選`Q`皇家同花順：
<img width="1046" height="744" alt="image" src="https://github.com/user-attachments/assets/c7d0ce72-b142-4381-b541-edcc5b8d3eea" />

**範例三**：提醒功能
<img width="1018" height="743" alt="image" src="https://github.com/user-attachments/assets/7f084769-e937-42c5-b236-28854231204a" />
<img width="1035" height="739" alt="image" src="https://github.com/user-attachments/assets/c9d63c79-a946-42a6-ba02-dab6565674b7" />

## 賠率表說明
[cite_start]根據作業講義 [cite: 23]，牌型賠率設定如下：

| 牌型 | 賠率 | 牌型 | 賠率 |
| :--- | :--- | :--- | :--- |
| **皇家同花順** | **250** | **順子** | **4** |
| **同花順** | **50** | **三條** | **3** |
| **四條 (鐵支)** | **25** | **兩對** | **2** |
| **葫蘆** | **9** | **一對** | **1** |
| **同花** | **6** | **雜牌** | **0** |

## 測試專用快捷鍵 (發牌後生效)
本程式支援以下快捷鍵進行牌型測試，以便驗證賠率計算：
* `Q`：皇家同花順
* `W`：同花順
* `E`：同花
* `R`：鐵支
* `T`：葫蘆
* `Y`：三條
