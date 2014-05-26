// ������������!
// ���������, ��� �� ������ ������������� � F# Coding Dojo!
// ���� ���� ����������� � ������������� �������� ���������� (dmitri@soshnikov.com)
// �� ������ ������� https://github.com/c4fsharp/Dojo-Digits-Recognizer/blob/master/Dojo/GuidedScript.fsx 

// 1. ������ ����

// ��������� ����������
// ����� ��� ������ �������, ���� ��������� ��� ������� � F# Interactive
// (�������� ��� ������� � ������ Alt-Enter)
  
open System
open System.IO

// ����������� ������� .NET-����������
// File.ReadAllLines(path)
// ������� ���������� ������ �����
// ��������, �������� ��������� ������ ���� � �����
 
// [ YOUR CODE GOES HERE! ]
 
 
// 2. ��������� �������
 
// ����������� Array.map, ����� ������� ������ ������� �� �������
// � ���� ������� �������
 
// ����� ���������� ��������� ������:
let csvToSplit = "1,2,3,4,5"
let splitResult = csvToSplit.Split(',')
 
 
// [ YOUR CODE GOES HERE! ]
 
 
// 3. ������� ���������
 
// ���������: ����������� array slicing operators ��� ��������
let someNumbers = [| 0 .. 10 |] 
let first = someNumbers.[0] 
let twoToFive = someNumbers.[ 1 .. 4 ]
let upToThree = someNumbers.[ .. 2 ] 

// [ YOUR CODE GOES HERE! ]
 
 
// 4. ����������� � �����
 
// � ����� �������� ���������� ������. ������� ����������� �� � ����� �����
// ������ �������������� ������ � �����:
let castedInt = (int)"42"
let convertedInt = Convert.ToInt32("42")
let funnyCast = "42" |> int 
 
// [ YOUR CODE GOES HERE! ]
 
 
// 5. ����������� ������� � ������
 
// ��� �������� ����� ������������ ������ ��� �������� ���������� �� ����� �����
// ����������� ��� ����� ���:
type Example = { Label:int; Pixels:int[] }
// ���������� ������� ��������� ��������� �������:
let example = { Label = 1; Pixels = [| 1; 2; 3; |] }
 
// [ YOUR CODE GOES HERE! ]
 
 
// 6. ��������� ����������
 
// ��� ���� ��������� ��������� ���������� ����� �������������
// �����������: ��������� ���������� ����������� ���
// distance [ x1; y1; z1 ] [ x2; y2; z2 ] = 
// sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2))
// ���������: ��� ���������� ��������� ����� (������������ ����������)
// ���������� ����� �� �������������

// ��� ����� ���������� ������� Array.map2
// ��������, ��� ��� ��� ������������ ��� ���������� ����� ���� ��������-��������:
let point1 = [| 0; 1; 2 |]
let point2 = [| 3; 4; 5 |]
let map2Example = 
    Array.map2 (fun p1 p2 -> p1 + p2) point1 point2

// ����� ����� ������������� ��� � �������
let map2PointsExample (P1: int[]) (P2: int[]) =
    Array.map2 (fun p1 p2 -> p1 + p2) P1 P2


// ���������� �������, ����������� ���������� ����� ����������� �������������
let distance (p1: int[]) (p2: int[]) = 42
 
// [ YOUR CODE GOES HERE! ]
 
 
// 7. ��������� �������������
 
// �� ������ � ����, ����� �������� �������������!
// ��� ���������� ������� Array.minBy 
// ������� ������� � ������� ����������� ������� �� ���������� ��������
// ��������, ����� � ��� ���� ������:
let someData = 
    [| { Label = 0; Pixels = [| 0; 1 |] };
       { Label = 1; Pixels = [| 9; 2 |] };
       { Label = 2; Pixels = [| 3; 4 |] }; |]
// ��������, ������ ������� � ������������ ������ ��������
let findThatGuy = 
    someData 
    |> Array.maxBy (fun x -> x.Pixels.[0])
 
// F# ������ �������� � �����������, ��������
let immutableValue = 42
let functionWithClosure (x: int) =
    if x > immutableValue // ���������� �������� ����� �������
    then true
    else false
 
// ������������� ������ �������� �� ���� ������ ��������
// � ���������� ������������ �����
let classify (unknown:int[]) =
    // ��� ���� ������� ���-�� �����
    // �������� ����� � ������� ��������� �������� TrainingSample
    // ������� � ����������� ����������� �� unknown
    // ��������� ���������...
    0 
 
// [ YOUR CODE GOES HERE! ]
 
 
// 8. ��������� �������� ������
 
// ������� �������� ������� ��������� ������������ ���� ��� 500
// �������� ������ �� ����� validationsample.csv. 
 
// [ YOUR CODE GOES HERE! ]

// 9. �����������!
// ��� ����� ������� ������:
// - ��������� �� http://www.kaggle.com/c/digit-recognizer ������ ���� � 50000 ���������
//   � ����� ��������� �������� ������������� ����� ����������� ����� �����. ���������� ������
//   ����������� �������� ������������� �� ���� ������������� ������ ��������� ������
// - ����������, ���������� �� �������� �� ������� �������
// - ��������� ����� �� ��������� �������� � ������� System.Drawing � ����������, ��� ��� ��������
// - �������� �������������� � ���������� (��� �������� ������), ������� ����� ��������� �������� �����
//   �� touch-������ � ������������ �
// - ��������� ������������ ������ ������
