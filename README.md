# cs-form-mtn-003-vs2022

- ### 新規入力にあたり、社員マスタの存在チェック
  - データベース用クラス( System.Data.Odbc ) をインストール
  - 接続文字列による接続
  - コマンドオブジェクトで SQL の設定
  - OdbcDataReader で読み込んで存在チェック
    - 存在したらメッセージを表示して社員コードを再入力
    - 存在しなかったら第二会話へ遷移

![image](https://github.com/winofsql/cs-form-mtn-003-vs2022/assets/1501327/2ede9427-9e41-454d-a2f4-cd4a942673cf)
