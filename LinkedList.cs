class CircularLinkedList<T> where T : struct
{
    private Node<T> head = null;
    private Node<T> tail = null;
    private int length = 0;

    public void Add(T value)
    {
        Node<T> node = new Node<T>(value);
        node.SetNext(this.head);
        if(this.head == null)
        {
            this.head = node;
            this.tail = node;
        }
        else
        {
            int index = this.length;
            Node<T> ptr = this.head;
            while(index > 1)
            {
                ptr = ptr.Next();
                index--;
            }
            ptr.SetNext(node);
            this.tail = node;
        }
        this.length++;
    }

    public void printListGarland() 
    {
        int index = this.length;
        Node<T> ptr = this.head;
        while(index > 0) {
            Console.Write(ptr.GetValue);
            ptr = ptr.Next();
            index--;
        }
    }

    /*1.2 ดอกบานไม่รู้โรยจะเรียงติดต่อกันได้ไม่เกิน 3 ดอก
    เช็ค G (ดอกบานไม่รู้โรย)
    ถ้าหากว่า this.length (ตัวแปรที่เอาไว้นับว่าตัวแปรมีกี่ตัวแล้ว) มีตัวแปรมากกว่า 3
    ใช้ while loop ส่งตัวแปรไปยังตัวถัดไป
    แล้วใช้ while loop เช็ค G ว่ามีเกิน 3 ตัวหรือเปล่า
    */

    /*1.3 ดอกกุหลาบจะต้องอยู่ระหว่าง ดอกไม้ 2 ชนิดที่แตกต่างกัน
    เมื่อใส่ J G O
    เช็คว่าข้างหน้าเหมือนกับข้างหลังหรือเปล่า ถ้าหากเหมือนให้ false
    และเช็คว่าข้างหลังเหมือนกับข้างหน้าหรือเปล่า ถ้าหากเหมือนให้ false
    */
}