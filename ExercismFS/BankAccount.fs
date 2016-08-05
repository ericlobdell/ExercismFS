module BankAccount

type Account = {
    Balance: double
    IsOpen: bool
}

let getBalance account =
    if account.IsOpen then Some(account.Balance) else None

let mkBankAccount() = 
    { Balance = 0.0; IsOpen = false }

let openAccount account =
    { Balance = account.Balance; IsOpen = true }

let closeAccount account =
    { Balance = account.Balance; IsOpen = false }

let updateBalance amount account =
    { Balance = account.Balance + amount; IsOpen = account.IsOpen }






    
