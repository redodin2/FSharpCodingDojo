

// ���������� ���������
let ������� x = x*2
let �������_��� x = x*2.

������� 1
������� (������� 1)
(������� >> �������) 1
1 |> ������� |> �������
������� <| 1 |> �������

// ��������
let rec solve f a b =
   let c = (b+a)/2.
   if (b-a)<0.001 then c
   else 
     if f(a)*f(c)<0. then solve f a c
     else solve f c b

solve (fun x -> -1.+x*x-sin x) -3. 3.

// ��������������� ��������

let rec state_rec init trans pred =
     if pred init then init
     else state_rec (trans init) trans pred

let solve f a b = state_rec (a,b)
                    (fun (a,b) ->
                       let c = (a+b)/2.
                       if f(a)*f(c)<0. then (a,c) else (c,b))
                    (fun (a,b) -> b-a<0.001)
                  |> fst

solve (fun x -> -1.+x*x-sin x) -3. 3.

// ������ ��������� ����

// ��������� ����������
// ����� ��� ������ �������, ���� ��������� ��� ������� � F# Interactive
// (�������� ��� ������� � ������ Alt-Enter)
open System
open System.IO

// ������� ��� ������ ����� ��� ������� �����
let read fn = File.ReadAllLines(sprintf "%s\%s" __SOURCE_DIRECTORY__ fn)
read @"data\wap.txt"

// ��� ���������� ������ � F#: �������, ������, ������������������
let array = [|1;2;3;4;5|]
let list = [1;2;3;4;5]
let sq = {1..5}

Array.length array
List.length list
Seq.length list

list |> Seq.length

// ������� ������� ������ � �������
[1..5] |> List.map (fun x->x*2)
[1..5] |> List.map ((*)2)

[1..5] |> List.filter (fun x->x%2=0)
let swap f x y = f y x
[1..5] |> List.filter (swap(%)2>>(=)0)

[1..5] |> List.fold (fun acc x -> (if acc="" then "" else acc+",")+x.ToString()) ""

let sqr x = x*x
[1..100] |> List.map sqr |> List.sum
{1..100} |> Seq.map sqr |> Seq.sum

// ������������ �����:
let book = read @"data\wap.txt"

// �������� ������ ����, ������� 3 ��������
let words=
 book |> Array.map (fun s -> s.Split([|' ';';';'.';',';'!';'-';'�';'!';'"';')';'(';'/'|]))
      |> Array.concat
      |> Array.filter (fun s -> s.Length>3)

// ����� ����� ������� �����
words |> Array.maxBy(fun s -> s.Length)

// ������������� ���� �� �����
words |> Seq.groupBy (fun s -> s.Length)
      |> Seq.map (fun (n,s) -> (n, Seq.length s))
      |> Seq.sortBy fst


// ��������� ���������� ������������
#load @"lib\FSharp.Charting.fsx"

open FSharp.Charting

words |> Seq.groupBy (fun s -> s.Length)
      |> Seq.map (fun (n,s) -> (n, Seq.length s))
      |> Seq.sortBy fst
      |> Chart.Bar

// ������ ��������� �������
words |> Seq.groupBy (fun s -> s)
      |> Seq.map (fun (n,s) -> (n, Seq.length s))
      |> Seq.sortBy (fun (n,s) -> -s)
      |> Seq.take 5
      |> Chart.Bar
